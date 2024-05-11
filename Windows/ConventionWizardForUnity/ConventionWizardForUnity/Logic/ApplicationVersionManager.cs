using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace ConventionWizardForUnity
{
    ///==========================================================================================================================
    ///
    ///  Application Version Manager
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  Convention Wizard For Unity의 최신 버전을 가져오는 클래스
    ///  </summary>
    ///
    ///==========================================================================================================================
    public static class ApplicationVersionManager
    {
        ///======================================================================================================================
        ///  PUBLIC STATIC 변수
        ///======================================================================================================================
        /// <summary>
        /// 현재 사용중인 Convention Wizard For Unity Application의 버전 정보
        /// </summary>
        public static Version CurrentApplicationVersion
        {
            get; private set;
        }

        /// <summary>
        /// 현재 릴리즈된 가장 최신 Convention Wizard For Unity Application의 버전 정보
        /// </summary>
        public static Version LatestApplicationVersion
        {
            get; private set;
        }

        /// <summary>
        /// Convention Wizard For Unity Application을 다운로드 받을 수 있는 Git release 주소
        /// </summary>
        public static readonly string ApplicationGitDownloadURL =
                                            "https://api.github.com/repos/KimYC1223/ConventionWizardForUnity/releases/latest";

        ///======================================================================================================================
        /// static class 생성자
        ///======================================================================================================================
        static ApplicationVersionManager()
        {
            // var splitedVersionString = Application.ProductVersion.Split('.')[..1];
            CurrentApplicationVersion = new Version(1, 0, 0);
            LatestApplicationVersion = new Version(0, 0, 0);
        }

        ///======================================================================================================================
        /// <summary>
        /// Convention Wizard For Unity의 최신 버전을 가져오는 비동기 메서드
        /// </summary>
        /// <returns>최신 버전 정보</returns>
        ///======================================================================================================================
        public static async Task<Version> GetVersionAsync()
        {
            string responseText = string.Empty;

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
            httpClient.DefaultRequestHeaders.Add("ContentType", "application/vnd.github+json");
            httpClient.DefaultRequestHeaders.Add("Method", "GET");
            httpClient.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "ConventionWizardForUnity");

            using var resp = await httpClient.GetAsync(ApplicationGitDownloadURL);
            var status = resp.StatusCode;
            if (status != HttpStatusCode.OK && status != HttpStatusCode.Moved &&
                status != HttpStatusCode.Redirect && status != HttpStatusCode.Accepted)
            {
                throw new HttpListenerException();
            }

            responseText = await resp.Content.ReadAsStringAsync();
            try
            {
                var jObject = JObject.Parse(responseText)["tag_name"];

                if (jObject is not null)
                {
                    responseText = ExtractVersion(jObject.ToString());
                }
                else
                {
                    responseText = "0.0.0";
                }

                LatestApplicationVersion = new Version(responseText);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
            return LatestApplicationVersion;
        }

        ///======================================================================================================================
        /// <summary>
        /// 주어진 string에서 버전 정보 패턴(Major.Minor.Patch)을 찾아내 리턴하는 메서드
        /// </summary>
        /// <param name="input">주어진 스트링</param>
        /// <returns>Major.Minor.Patch 형태의 버전 정보<br />만약, 패턴을 찾아내지 못하면 "0.0.0" 리턴</returns>
        ///======================================================================================================================
        private static string ExtractVersion(string input)
        {
            string pattern = @"\b\d+\.\d+\.\d+\b";                  // 숫자.숫자.숫자 패턴
            var match = Regex.Match(input, pattern);                // 정규식에 매칭되는 부분 찾기
            return (match.Success) ? match.Value : "0.0.0";
        }
    }
}