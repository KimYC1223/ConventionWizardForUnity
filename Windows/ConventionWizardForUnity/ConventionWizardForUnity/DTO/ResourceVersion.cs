using ConventionWizardForUnity.Enum;

using System;

namespace ConventionWizardForUnity.DTO
{
    ///==========================================================================================================================
    ///
    ///  Resource Version
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  프로그램에서 사용하는 Resource의 버전 정보를 담고있는 DTO
    ///  </summary>
    ///
    ///==========================================================================================================================
    [Serializable]
    public class ResourceVersion
    {
        /// <summary>
        /// 리소스 업데이트 가능 여부
        /// </summary>
        public RESOURCE_UPDATE_STATE UpdateState;

        /// <summary>
        /// 현재 로컬 PC에 설치된 리소스 버전
        /// </summary>
        public string CurrentVersion;

        /// <summary>
        /// 현재 릴리즈된 가장 최신 리소스 버전
        /// </summary>
        public string LatestVersion;
    }
}