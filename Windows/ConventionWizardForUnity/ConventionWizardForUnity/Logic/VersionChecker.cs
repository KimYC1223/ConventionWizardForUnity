using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ConventionWizardForUnity
{
    ///==========================================================================================================================
    ///
    ///  Version Checker
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  Convention Wizard For Unity의 최신 버전을 가져오는 클래스
    ///  </summary>
    ///  
    ///==========================================================================================================================
    internal class VersionChecker
    {
        ///======================================================================================================================
        /// <summary>
        /// Convention Wizard For Unity의 최신 버전을 가져오는 메서드
        /// </summary>
        /// <returns>최신 버전 정보</returns>
        ///======================================================================================================================
        public string GetVersion()
        {
            string gitRepositoryURL = "https://api.github.com/repos/KimYC1223/ConventionWizardForUnity/releases/latest";
            string responseText = string.Empty;

            var request = (HttpWebRequest)WebRequest.Create(gitRepositoryURL);
            request.ContentType = "application/vnd.github+json";
            request.Accept = "application/vnd.github+json";
            request.Method = "GET";
            request.UserAgent = "request";
            request.Headers.Add("X-GitHub-Api-Version: 2022-11-28");
            request.Timeout = 3 * 1000; // 30초

            using (var resp = (HttpWebResponse)request.GetResponse())
            {
                var status = resp.StatusCode;
                Console.WriteLine(status);  // 정상이면 "OK"

                var respStream = resp.GetResponseStream();
                using (var sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                    var jObject = JObject.Parse(responseText);
                    try
                    {
                        responseText = jObject["tag_name"].ToString();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }

            return responseText;
        }
    }
}