using ConventionWizardForUnity.DTO;
using ConventionWizardForUnity.Enum;

using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ConventionWizardForUnity.Logic
{
    ///==========================================================================================================================
    ///
    ///  Resource Version Manager
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  앱에서 사용하는 각종 리소스들의 업데이트 상황을 파악하거나, 최신화 하는 클래스
    ///  </summary>
    ///
    ///==========================================================================================================================
    public static class ResourceVersionManager
    {
        ///======================================================================================================================
        /// public 델리게이트
        ///======================================================================================================================
        public delegate void ProgressCallback(float value, int currentIndex, int totalIndex);

        ///======================================================================================================================
        /// public STATIC 변수
        ///======================================================================================================================
        /// <summary>
        /// 현재 로컬 머신이 알고있는 리소스 정보
        /// </summary>
        public static ResourceURLData LocalResourceURL { get; private set; }

        /// <summary>
        /// 서버에 올라온 최신 리소스 정보
        /// </summary>
        public static ResourceURLData ServerResourceURL { get; private set; }

        /// <summary>
        /// 리소스 최신화 상태 현황
        /// </summary>
        public static ResourceVersion ResourceVersionState { get; private set; }

        ///======================================================================================================================
        /// PRIVATE STATIC 변수
        ///======================================================================================================================
        // 리소스 서버 정보를 담고있는 json 파일의 경로
        private static string serverInfoFile = Path.Combine(Application.StartupPath, "Resources", "ConventionWizardInfo.json");

        // 현재 로컬 PC가 알고있는 리소스 정보를 담고있는 json 파일의 경로
        private static string resourceURLFile = Path.Combine(Application.StartupPath, "Resources", "ResourceWizardInfo.json");

        ///======================================================================================================================
        /// STATIC CLASS 생성자
        ///======================================================================================================================
        static ResourceVersionManager()
        {
            LocalResourceURL = new ResourceURLData();
            ServerResourceURL = new ResourceURLData();
            ResourceVersionState = new ResourceVersion
            {
                UpdateState = RESOURCE_UPDATE_STATE.UNKOWN,
                CurrentVersion = new Version(0, 0, 0).ToString(),
                LatestVersion = new Version(0, 0, 0).ToString(),
            };
        }

        ///======================================================================================================================
        /// <summary>
        /// 현재 리소스 업데이트가 필요한지 확인하는 메서드
        /// </summary>
        /// <returns>리소스 버전 상태</returns>
        ///======================================================================================================================
        public static async Task<ResourceVersion> CheckResourceUpdateAsync()
        {
            var resourceURLDataTuple = await GetJsonFilesAsync();

            LocalResourceURL = resourceURLDataTuple.Item1;
            ServerResourceURL = resourceURLDataTuple.Item2;

            var localVersion = new Version(ExtractVersion(LocalResourceURL.ConventionVersion.ToString()));
            var serverVersion = new Version(ExtractVersion(ServerResourceURL.ConventionVersion.ToString()));

            ResourceVersionState.UpdateState = (localVersion < serverVersion) ? RESOURCE_UPDATE_STATE.UPDATE_REQUIRED :
                                                                               RESOURCE_UPDATE_STATE.LATEST;
            ResourceVersionState.CurrentVersion = localVersion.ToString();
            ResourceVersionState.LatestVersion = serverVersion.ToString();

            return ResourceVersionState;
        }

        ///======================================================================================================================
        /// <summary>
        /// 현재 알고있는 리소스 정보를 업데이트하는 메서드
        /// </summary>
        /// <param name="progressCallback"></param>
        /// <returns></returns>
        ///======================================================================================================================
        public static async Task<Dictionary<string, bool>> UpdateResourceAsync(ProgressCallback progressCallback)
        {
            // 업데이트 여부부터 확인하도록 함
            if (ResourceVersionState.UpdateState == RESOURCE_UPDATE_STATE.UNKOWN)
            {
                await CheckResourceUpdateAsync();
            }

            // 업데이트할 필요 없으면, 빈 dictionary 리턴
            var result = new Dictionary<string, bool>();
            if (ResourceVersionState.UpdateState == RESOURCE_UPDATE_STATE.LATEST)
            {
                return result;
            }

            var resourcesKey = LocalResourceURL.ResourceURLDictionary.Keys;

            progressCallback?.Invoke(value: 0f, currentIndex: 0, totalIndex: resourcesKey.Count);

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Method", "GET");

            foreach (var item in resourcesKey.Select((value, index) => (value, index)))
            {
                var resourcePath = item.value;
                var amount = ((float)(item.index) / (float)(resourcesKey.Count));
                progressCallback?.Invoke(value: amount, currentIndex: item.index, totalIndex: resourcesKey.Count);

                var serverURL = ServerResourceURL.ResourceURLDictionary[resourcePath];

                var targetFilePath = Path.Combine(Application.StartupPath, "Resources", resourcePath);
                var tempFilePath = Path.Combine(Application.StartupPath, "Resources", $"{resourcePath}.tmp");

                try
                {
                    using var resp = await httpClient.GetAsync(serverURL);
                    if (resp.StatusCode != HttpStatusCode.OK && resp.StatusCode != HttpStatusCode.Moved &&
                        resp.StatusCode != HttpStatusCode.Redirect && resp.StatusCode != HttpStatusCode.Accepted)
                    {
                        result[resourcePath] = false;
                        continue;
                    }

                    // Step 1 . File download
                    var responseContent = await resp.Content.ReadAsStringAsync();
                    using var sw = new StreamWriter(tempFilePath);
                    await sw.WriteAsync(responseContent);

                    // Step 2 . Move file
                    result[resourcePath] = MoveFile(sourceFilePath: tempFilePath, destFilePath: targetFilePath);
                }
                catch
                {
                    result[resourcePath] = false;
                }
                finally
                {
                    // Step 3 . Delete temp file
                    DeleteFile(tempFilePath);
                }
            }
            progressCallback?.Invoke(value: 1f, currentIndex: resourcesKey.Count, totalIndex: resourcesKey.Count);

            return result;
        }

        private static string ExtractVersion(string input)
        {
            string pattern = @"\b\d+\.\d+\.\d+\b";                  // 숫자.숫자.숫자 패턴
            var match = Regex.Match(input, pattern);                // 정규식에 매칭되는 부분 찾기
            return (match.Success) ? match.Value : "1.0.0";
        }

        private static bool DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath) == true)
                {
                    File.Delete(filePath);
                }
                return true;
            }
            catch
            {
                Debug.WriteLine($"[ ResourceVersionManager::DeleteFile ]  파일 {filePath}을(를) 삭제하는데 실패했습니다.");
                return false;
            }
        }

        private static bool MoveFile(string sourceFilePath, string destFilePath)
        {
            try
            {
                if (DeleteFile(destFilePath) == true && File.Exists(destFilePath) == false)
                {
                    File.Move(sourceFilePath, destFilePath);
                }
                return true;
            }
            catch
            {
                Debug.WriteLine($"[ ResourceVersionManager::MoveFile ]  파일 {sourceFilePath}을(를) 옮기지 못했습니다.");
                return false;
            }
        }

        private static async Task<Tuple<ResourceURLData, ResourceURLData>> GetJsonFilesAsync()
        {
            var serverInfo = await GetServerInfoAsync();
            var localResourceURLData = await GetResourceURLFromLocalAsync();
            var serverResourceURLData = await GetResourceURLFromServerAsync(serverURL: serverInfo.URL);

            return Tuple.Create(localResourceURLData, serverResourceURLData);
        }

        private static async Task<ConventionWizardServerInfo> GetServerInfoAsync()
        {
            ConventionWizardServerInfo? serverInfo = null;
            try
            {
                using var sr = new StreamReader(serverInfoFile);
                var serverInfoJsonString = await sr.ReadToEndAsync();
                serverInfo = JsonConvert.DeserializeObject<ConventionWizardServerInfo>(serverInfoJsonString);
                if (serverInfo is null)
                {
                    serverInfo = await CreateNewServerInfoFileAsync();
                }
            }
            catch
            {
                serverInfo = await CreateNewServerInfoFileAsync();
            }
            Debug.WriteLine($"serverInfo URL : {serverInfo.URL}");
            return serverInfo;
        }

        private static async Task<ResourceURLData> GetResourceURLFromLocalAsync()
        {
            ResourceURLData? resourceURLData = null;
            try
            {
                using var sr = new StreamReader(resourceURLFile);
                var resourceURLDataJsonString = await sr.ReadToEndAsync();
                resourceURLData = JsonConvert.DeserializeObject<ResourceURLData>(resourceURLDataJsonString);
                if (resourceURLData is null)
                {
                    resourceURLData = await CreateNewResourceURLDataAsync();
                }
            }
            catch
            {
                resourceURLData = await CreateNewResourceURLDataAsync();
            }
            Debug.WriteLine($"Local resourceURLData.ConventionGuideURL : {resourceURLData.ConventionGuideURL}");
            return resourceURLData;
        }

        private static async Task<ResourceURLData> GetResourceURLFromServerAsync(string serverURL)
        {
            Debug.WriteLine($"Hello, World! {serverURL}");
            ResourceURLData? resourceURLData = null;

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Method", "GET");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "ConventionWizardForUnity");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
            httpClient.DefaultRequestHeaders.Add("ContentType", "application/vnd.github+json");

            try
            {
                using var resp = await httpClient.GetAsync(serverURL);
                Debug.WriteLine(resp.StatusCode);
                if (resp.StatusCode != HttpStatusCode.OK && resp.StatusCode != HttpStatusCode.Moved &&
                    resp.StatusCode != HttpStatusCode.Redirect && resp.StatusCode != HttpStatusCode.Accepted)
                {
                    return await CreateNewResourceURLDataAsync(isCreateFile: false);
                }

                var responseContent = await resp.Content.ReadAsStringAsync();
                resourceURLData = JsonConvert.DeserializeObject<ResourceURLData>(responseContent);

                if (resourceURLData is null)
                {
                    resourceURLData = await CreateNewResourceURLDataAsync(isCreateFile: false);
                }

                Debug.WriteLine($"Get resource from server - main");
                return resourceURLData;
            }
            catch
            {
                Debug.WriteLine($"Get resource from server - catch");
                return await CreateNewResourceURLDataAsync(isCreateFile: false);
            }
        }

        private static async Task<ConventionWizardServerInfo> CreateNewServerInfoFileAsync()
        {
            var serverInfo = new ConventionWizardServerInfo()
            {
                URL = "https://raw.githubusercontent.com/KimYC1223/" +
                      "ConventionWizardResourceStorage/main/CSharp/ConventionWizardInfo.json"
            };

            using (var sw = new StreamWriter(serverInfoFile))
            {
                await sw.WriteAsync(JsonConvert.SerializeObject(serverInfo).ToString());
            }

            return serverInfo;
        }

        private static async Task<ResourceURLData> CreateNewResourceURLDataAsync(bool isCreateFile = false)
        {
            var resourceURLData = new ResourceURLData()
            {
                ConventionVersion = "1.0.0",
                ConventionTeamName = "",
                ConventionGuideURL = "https://github.com/KimYC1223/ConventionWizardForUnity/wiki/Convention-Wizard-For-Unity-%EC%BD%94%EB%93%9C-%EC%BB%A8%EB%B2%A4%EC%85%98",
                SnippetsWikiURL = "https://en.wikipedia.org/wiki/Snippet_(programming)",
                SnippetsGuideURL = "https://github.com/KimYC1223/ConventionWizardForUnity/wiki/Convention-Wizard-For-Unity-%EC%82%AC%EC%9A%A9%EB%B2%95-%EA%B0%80%EC%9D%B4%EB%93%9C#-7-c-%EC%BD%94%EB%93%9C-%EC%8A%A4%EB%8B%88%ED%8E%AB-%EA%B4%80%EB%A6%AC%ED%95%98%EB%8A%94-%EB%B2%95",
                ResourceURLDictionary =
                {
                    { "CodeBase\\Custom\\81-C# Script-NewBehaviourScript.cs" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/CodeBase/Custom/81-C%23%20Script-NewBehaviourScript.cs.txt" },
                    { "CodeBase\\Origin\\81-C# Script-NewBehaviourScript.cs" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/CodeBase/Origin/81-C%23%20Script-NewBehaviourScript.cs.txt"},
                    { "ConventionSetting\\.azuredevops\\pull_request_template.md" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.azuredevops/pull_request_template.md"},
                    { "ConventionSetting\\.github\\PULL_REQUEST_TEMPLATE.md" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.github/PULL_REQUEST_TEMPLATE.md"},
                    { "ConventionSetting\\.editorconfig" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.editorconfig"},
                    { "ConventionSetting\\CodeMaid.config" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/CodeMaid.config"},
                    { "Snippets\\cw_class.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_class.snippet"},
                    { "Snippets\\cw_field.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_field.snippet"},
                    { "Snippets\\cw_private_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_private_method.snippet"},
                    { "Snippets\\cw_private_static_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_private_static_method.snippet"},
                    { "Snippets\\cw_public_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_public_method.snippet"},
                    { "Snippets\\cw_public_static_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_public_static_method.snippet"},
                    { "Vsix\\CodeMaidVS2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/CodeMaidVS2022.vsix"},
                    { "Vsix\\CodeMaidVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/CodeMaidVS2019.vsix"},
                    { "Vsix\\GuidelinesVS2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/GuidelinesVS2019.vsix"},
                    { "Vsix\\GuidelinesVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/GuidelinesVS2022.vsix"},
                    { "Vsix\\SonarLintVs2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/SonarLintVs2019.vsix"},
                    { "Vsix\\SonarLintVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/SonarLintVS2022.vsix"}
                }
            };

            if (isCreateFile == true)
            {
                using var sw = new StreamWriter(resourceURLFile);
                await sw.WriteAsync(JsonConvert.SerializeObject(resourceURLData).ToString());
            }

            return resourceURLData;
        }
    }
}