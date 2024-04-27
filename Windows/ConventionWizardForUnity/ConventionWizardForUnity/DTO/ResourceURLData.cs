using System;
using System.Collections.Generic;

namespace ConventionWizardForUnity.DTO
{
    ///==========================================================================================================================
    ///
    ///  Resource URL Data
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  프로그램에서 사용하는 Resource URL Data에 관한 DTO
    ///  </summary>
    ///  
    ///==========================================================================================================================
    [Serializable]
    public class ResourceURLData
    {
        /// <summary>
        /// 사용중인 Resource URL Data 버전 정보
        /// </summary>
        public string ConventionVersion = string.Empty;

        /// <summary>
        /// Convention Wizard에 띄울 팀 정보
        /// </summary>
        public string ConventionTeamName = string.Empty;

        /// <summary>
        /// '코드 컨벤션 확인하러가기' 버튼을 눌렀을 때 이동할 링크
        /// </summary>
        public string ConventionGuideURL = string.Empty;

        /// <summary>
        /// '코드 스니펫이란?' 버튼을 눌렀을 때 이동할 링크
        /// </summary>
        public string SnippetsWikiURL = string.Empty;

        /// <summary>
        /// '설치 후 사용하는 방법' 버튼을 눌렀을 때 이동할 링크
        /// </summary>
        public string SnippetsGuideURL = string.Empty;

        /// <summary>
        /// Convention Wizard For Unity에서 사용하는 리소스들의 URL
        /// </summary>
        public Dictionary<string, string> ResourceURLDictionary;
    }
}
