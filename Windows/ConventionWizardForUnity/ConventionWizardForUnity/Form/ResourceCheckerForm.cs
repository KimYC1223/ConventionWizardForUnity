using ConventionWizardForUnity.Logic;
using ConventionWizardForUnity.Enum;

namespace ConventionWizardForUnity
{
    ///==========================================================================================================================
    ///
    ///  Initializing Form
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  <summary>
    ///  Convention Wizard For Unity Application에서 사용하고 있는 리소스의 버전 관리 및 테스트를 진행하는 클래스
    ///  </summary>
    ///
    ///==========================================================================================================================
    public partial class InitializingForm : Form
    {
        ///======================================================================================================================
        /// PRIVATE 멤버 변수
        ///======================================================================================================================
        private readonly int descriptionTextMaxLength = 45;         // 현재 설명하는 String의 최대 글자 수

        private Action? buttonCallback;                             // 버튼을 눌렀을 때 호출되는 콜백
        private CancellationTokenSource downloadCancelTokenSource;  // 다운로드 캔슬 토큰

        ///======================================================================================================================
        /// <summary>
        /// Form의 기본 생성자
        /// </summary>
        ///======================================================================================================================
        public InitializingForm()
        {
            //===================================================================================================================
            //  STEP 00. Initialize Field
            //===================================================================================================================
            InitializeComponent();
            downloadCancelTokenSource = new CancellationTokenSource();

            SetVersionLabelText(ApplicationVersionManager.CurrentApplicationVersion);
            bool isApplicationUpdatedCanceled = false;

            Task.Run(async () =>
            {
                //===============================================================================================================
                //  STEP 01. Application version check
                //===============================================================================================================
                SetStatusLabelText("Application 최신 버전 확인중 ...");
                try
                {
                    var version = await ApplicationVersionManager.GetVersionAsync();
                    if (version.ToString().Equals("0.0.0") == true)
                    {
                        throw new Exception("Latest version parsing error");
                    }
                }
                catch
                {
                    // 버전을 확인하는 과정에서 문제가 생긴 경우
                    MessageBox.Show("업데이트 정보를 가져오는중 문제가 발생했습니다.\r" +
                                    $"인터넷 연결 상태를 확인하세요.\r\r업데이트 없이 기존 버전" +
                                    $"({ApplicationVersionManager.CurrentApplicationVersion})으로 진행합니다.",
                                    "업데이트 확인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isApplicationUpdatedCanceled = true;
                }

                // 현재 버전보다 새로운 버전이 나온 경우
                if (ApplicationVersionManager.LatestApplicationVersion > ApplicationVersionManager.CurrentApplicationVersion)
                {
                    if (MessageBox.Show($"신규 어플리케이션 버전(버전 : {ApplicationVersionManager.LatestApplicationVersion})" +
                                        "이 릴리즈 되었습니다.\r업데이트 하시겠습니까?\r\r" +
                                        $"  ▶ 현재 버전 : {ApplicationVersionManager.CurrentApplicationVersion}\r",
                                        "업데이트 가능", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start(ApplicationVersionManager.ApplicationGitDownloadURL);
                        Close();
                        return;
                    }

                    isApplicationUpdatedCanceled = true;
                }

                // Application 업데이트를 진행하지 않을 경우, Resource 업데이트 또한 진행하지 않음
                if (isApplicationUpdatedCanceled == true)
                {
                    await ResourceVersionManager.CheckResourceUpdateAsync();
                    SetProgressbarValue(100);
                    SetStatusLabelText("Application 업데이트 진행 하지 않음");
                    SetNextButtonText("앱 실행");
                    SetNextButtonEnable(true);
                    SetButtonCallbackForShowNextForm();
                    return;
                }
                SetProgressbarValue(10);

                //===============================================================================================================
                //  STEP 02. Resource version check
                //===============================================================================================================
                SetStatusLabelText("Resource 최신 버전 확인중 ...");
                var updateState = await ResourceVersionManager.CheckResourceUpdateAsync();
                SetProgressbarValue(20);

                // 리소스도 최신 상태일 때
                if (updateState.UpdateState == RESOURCE_UPDATE_STATE.LATEST)
                {
                    MessageBox.Show("어플리케이션 및 컨벤션 리소스가 최신상태입니다.\r\r" +
                                    $"  ▶ 어플리케이션  버전 : {ApplicationVersionManager.CurrentApplicationVersion}\r" +
                                    $"  ▶ 컨벤션 리소스 버전 : {updateState.CurrentVersion}\r",
                                    "업데이트 확인 결과", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetStatusLabelText("Application 업데이트 진행 하지 않음");
                    SetNextButtonText("앱 실행");
                    SetNextButtonEnable(true);
                    SetButtonCallbackForShowNextForm();
                    return;
                }

                if (MessageBox.Show($"신규 컨벤션 리소스(버전 : {updateState.LatestVersion})이" +
                                    "릴리즈 되었습니다. 컨벤션 리소스를 업데이트 하시겠습니까?\r\r" +
                                    $"현재 버전 : {updateState.CurrentVersion}\r",
                                    "업데이트 가능", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Process.Start(ApplicationVersionManager.ApplicationGitDownloadURL);
                    Close();
                }
            });
        }

        ///======================================================================================================================
        /// 버전 정보 텍스트 바꾸는 메서드
        ///======================================================================================================================
        private void SetVersionLabelText(Version ver)
        {
            if (VersionLabel.InvokeRequired == true)
            {
                BeginInvoke(new Action(() => { SetVersionLabelTextMain(ver); }));
                return;
            }
            SetVersionLabelTextMain(ver);
        }

        ///======================================================================================================================
        /// 버전 정보 텍스트 바꾸는 메서드 (메인)
        ///======================================================================================================================
        private void SetVersionLabelTextMain(Version ver)
        {
            VersionLabel.Text = $"Version : {ver}";
        }

        ///======================================================================================================================
        /// 프로그레스 바 값 바꾸는 메서드
        ///======================================================================================================================
        private void SetProgressbarValue(int value)
        {
            if (ProgressBar.InvokeRequired == true)
            {
                BeginInvoke(new Action(() => { SetProgressbarValueMain(value); }));
                return;
            }
            SetProgressbarValueMain(value);
        }

        ///======================================================================================================================
        /// 프로그레스 바 값 바꾸는 메서드 (메인)
        ///======================================================================================================================
        private void SetProgressbarValueMain(int value)
        {
            ProgressBar.Value = value;
        }

        ///======================================================================================================================
        /// 작업 설명 텍스트 바꾸는 메서드
        ///======================================================================================================================
        private void SetStatusLabelText(string text)
        {
            if (StatusLabel.InvokeRequired == true)
            {
                BeginInvoke(new Action(() => { SetStatusLabelTextMain(text); }));
                return;
            }
            SetStatusLabelTextMain(text);
        }

        ///======================================================================================================================
        /// 작업 설명 텍스트 바꾸는 메서드 (메인)
        ///======================================================================================================================
        private void SetStatusLabelTextMain(string str)
        {
            if (str.Length > descriptionTextMaxLength)
            {
                StatusLabel.Text = $"{str[..descriptionTextMaxLength]} ...";
            }
            StatusLabel.Text = str;
        }

        ///======================================================================================================================
        /// 버튼 텍스트 바꾸는 메서드
        ///======================================================================================================================
        private void SetNextButtonText(string text)
        {
            if (NextButton.InvokeRequired == true)
            {
                BeginInvoke(new Action(() => { SetNextButtonTextMain(text); }));
                return;
            }
            SetNextButtonTextMain(text);
        }

        ///======================================================================================================================
        /// 버튼 텍스트 바꾸는 메서드 (메인)
        ///======================================================================================================================
        private void SetNextButtonTextMain(string text)
        {
            NextButton.Text = text;
        }

        ///======================================================================================================================
        /// 버튼 활성화정도를바꾸는 메서드
        ///======================================================================================================================
        private void SetNextButtonEnable(bool value)
        {
            if (NextButton.InvokeRequired == true)
            {
                BeginInvoke(new Action(() => { SetNextButtonEnableMain(value); }));
                return;
            }
            SetNextButtonEnableMain(value);
        }

        ///======================================================================================================================
        /// 버튼 활성화정도를바꾸는 메서드 (메인)
        ///======================================================================================================================
        private void SetNextButtonEnableMain(bool value)
        {
            NextButton.Enabled = value;
        }

        ///======================================================================================================================
        /// 버튼을 눌렀을 때, 실행되는 메서드
        ///======================================================================================================================
        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            buttonCallback?.Invoke();
        }

        ///======================================================================================================================
        /// 버튼을 눌렀을 때, 다음 Form을 띄우도록 하는 메서드
        ///======================================================================================================================
        private void SetButtonCallbackForShowNextForm()
        {
            buttonCallback = () =>
            {
                SetNextButtonEnable(false);
                var mainForm = new MainForm();
                mainForm.Show();
                Close();
            };
        }

        ///======================================================================================================================
        /// 버튼을 눌렀을 때, 진행중인 리소스 다운로드를 취소하는 메서드
        ///======================================================================================================================
        private void SetButtonCallbackForCancelDownload()
        {
            buttonCallback = () =>
            {
                downloadCancelTokenSource.Cancel();
                SetStatusLabelText("컨벤션 리소스 업데이트 취소");
                SetNextButtonText("앱 실행");
                SetNextButtonEnable(true);
                SetButtonCallbackForShowNextForm();
            };
        }
    }
}