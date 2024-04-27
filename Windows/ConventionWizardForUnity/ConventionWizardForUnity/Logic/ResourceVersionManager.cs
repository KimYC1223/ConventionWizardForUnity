using ConventionWizardForUnity.DTO;

using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
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
        private static string serverInfoFilePath = 
                                    Path.Combine(Application.StartupPath, "Resource", "ConventionWizardInfo.json");
        private static string resourceURLFilePath = 
                                    Path.Combine(Application.StartupPath, "Resource", "ResourceWizardInfo.json");

        public static async Task<Tuple<bool,string>> CheckResourceUpdate()
        {
            var resourceURLDataTuple = await GetJsonFilesAsync();
            var localVersion = new Version(ExtractVersion(resourceURLDataTuple.Item1.ConventionVersion.ToString()));    // local
            var serverVersion = new Version(ExtractVersion(resourceURLDataTuple.Item2.ConventionVersion.ToString()));   // server

            return Tuple.Create(localVersion < serverVersion, serverVersion.ToString());
        }

        private static string ExtractVersion(string input)
        {
            string pattern = @"\b\d+\.\d+\.\d+\b";                  // 숫자.숫자.숫자 패턴
            var match = Regex.Match(input, pattern);                // 정규식에 매칭되는 부분 찾기
            return (match.Success) ? match.Value : "1.0.0";
        }

        private static async Task<Tuple<ResourceURLData, ResourceURLData>> GetJsonFilesAsync()
        {
            ConventionWizardServerInfo serverInfo = null;
            ResourceURLData localResourceURLData = null;
            ResourceURLData serverResourceURLData = null;

            serverInfo = await GetServerInfoAsync();
            localResourceURLData = await GetResourceURLFromLocalAsync();
            serverResourceURLData = await GetResourceURLFromServerAsync(serverURL: serverInfo.URL);

            return Tuple.Create(localResourceURLData, serverResourceURLData);
        }

        private static async Task<ConventionWizardServerInfo> GetServerInfoAsync()
        {
            ConventionWizardServerInfo serverInfo = null;
            try
            {
                using (var sr = new StreamReader(serverInfoFilePath))
                {
                    var serverInfoJsonString = await sr.ReadToEndAsync();
                    serverInfo = JsonConvert.DeserializeObject<ConventionWizardServerInfo>(serverInfoJsonString);
                }
            }
            catch
            {
                serverInfo = await CreateNewServerInfoFileAsync();
            }
            return serverInfo;
        }

        private static async Task<ResourceURLData> GetResourceURLFromLocalAsync()
        {
            ResourceURLData resourceURLData = null;
            try
            {
                using (var sr = new StreamReader(serverInfoFilePath))
                {
                    var resourceURLDataJsonString = await sr.ReadToEndAsync();
                    resourceURLData = JsonConvert.DeserializeObject<ResourceURLData>(resourceURLDataJsonString);
                }
            }
            catch
            {
                resourceURLData = await CreateNewResourceURLDataAsync();
            }

            return resourceURLData;
        }

        private static async Task<ResourceURLData> GetResourceURLFromServerAsync(string serverURL)
        {
            ResourceURLData resourceURLData = null;

            var request = (HttpWebRequest)WebRequest.Create(serverURL);
            request.Method = "GET";
            request.Timeout = 3 * 1000; // 30초

            try
            {
                using (var resp = (HttpWebResponse)(await request.GetResponseAsync()))
                {
                    var respStream = resp.GetResponseStream();
                    using (var sr = new StreamReader(respStream))
                    {
                        var responseText = await sr.ReadToEndAsync();
                        resourceURLData = JsonConvert.DeserializeObject<ResourceURLData>(responseText);
                    }
                }
            }
            catch
            {
                resourceURLData = await CreateNewResourceURLDataAsync(isCreateFile : false);
            }

            return resourceURLData;
        }

        private static async Task<ConventionWizardServerInfo> CreateNewServerInfoFileAsync()
        {
            var serverInfo = new ConventionWizardServerInfo()
            {
                URL = "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionWizardInfo.json"
            };

            using (var sw = new StreamWriter(serverInfoFilePath))
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
                    { ".\\CodeBase\\Custom\\81-C# Script-NewBehaviourScript.cs" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/CodeBase/Custom/81-C%23%20Script-NewBehaviourScript.cs.txt" },
                    { ".\\CodeBase\\Origin\\81-C# Script-NewBehaviourScript.cs" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/CodeBase/Origin/81-C%23%20Script-NewBehaviourScript.cs.txt"},
                    { ".\\ConventionSetting\\.azuredevops\\pull_request_template.md" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.azuredevops/pull_request_template.md"},
                    { ".\\ConventionSetting\\.github\\PULL_REQUEST_TEMPLATE.md" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.github/PULL_REQUEST_TEMPLATE.md"},
                    { ".\\ConventionSetting\\.editorconfig" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/.editorconfig"},
                    { ".\\ConventionSetting\\CodeMaid.config" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/ConventionSettingFile/CodeMaid.config"},
                    { ".\\Snippets\\cw_class.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_class.snippet"},
                    { ".\\Snippets\\cw_field.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_field.snippet"},
                    { ".\\Snippets\\cw_private_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_private_method.snippet"},
                    { ".\\Snippets\\cw_private_static_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_private_static_method.snippet"},
                    { ".\\Snippets\\cw_public_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_public_method.snippet"},
                    { ".\\Snippets\\cw_public_static_method.snippet" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Snippets/cw_public_static_method.snippet"},
                    { ".\\Vsix\\CodeMaidVS2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/CodeMaidVS2022.vsix"},
                    { ".\\Vsix\\CodeMaidVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/CodeMaidVS2019.vsix"},
                    { ".\\Vsix\\GuidelinesVS2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/GuidelinesVS2019.vsix"},
                    { ".\\Vsix\\GuidelinesVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/GuidelinesVS2022.vsix"},
                    { ".\\Vsix\\SonarLintVs2019.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/SonarLintVs2019.vsix"},
                    { ".\\Vsix\\SonarLintVS2022.vsix" , "https://raw.githubusercontent.com/KimYC1223/ConventionWizardResourceStorage/main/CSharp/Vsix/SonarLintVS2022.vsix"}
                }
            };

            if( isCreateFile == true )
            {
                using (var sw = new StreamWriter(resourceURLFilePath))
                {
                    await sw.WriteAsync(JsonConvert.SerializeObject(resourceURLData).ToString());
                }
            }

            return resourceURLData;
        }
    }
}
