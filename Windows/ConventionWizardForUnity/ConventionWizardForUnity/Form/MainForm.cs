using System.Text;
using ConventionWizardForUnity.Logic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ConventionWizardForUnity
{
    ///==========================================================================================================================
    ///
    ///  Convention Wizard For Unity
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  Convention Wizard For Unity의 로직 파트
    ///  2024.04.25 @KimYC1223
    ///
    ///==========================================================================================================================
    public partial class MainForm : Form
    {
        ///======================================================================================================================
        ///  PRIVATE 멤버 필드
        ///======================================================================================================================
        private readonly System.Windows.Forms.Timer uiButtonTimer;              // 버튼 연속 클릭을 방지할 타이머

        private string unityEditorRootPath = "C:\\Program Files\\Unity";        // Unity Hub가 설치된 기본 경로
        private string unityProjectPath = string.Empty;                         // 컨벤션 세팅을 적용할 프로젝트 경로
        private string snippetSavePath = string.Empty;                          // 코드 스니펫을 관리할 경로

        ///======================================================================================================================
        ///  기본 생성자 / 버전 확인후 출력
        ///======================================================================================================================
        public MainForm()
        {
            InitializeComponent();

            VersionLabel.Text = $"App v{ApplicationVersionManager.CurrentApplicationVersion} / " +
                                $"Resource v{ResourceVersionManager.ResourceVersionState.CurrentVersion}";
            uiButtonTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            TeamNameLabel.Text = (string.IsNullOrEmpty(ResourceVersionManager.LocalResourceURL.ConventionTeamName) == true) ?
                            string.Empty : $"Convention Rule : {ResourceVersionManager.LocalResourceURL.ConventionTeamName}";
            uiButtonTimer.Tick += new EventHandler(VsixInstallButtonEnableTimer);
        }

        ///======================================================================================================================
        ///  타이틀에 폰트를 적용하는 메서드
        ///======================================================================================================================
        private void MainForm_Load(object sender, EventArgs e)
        {
            var font1 = new Font(FontManager.FontFamilys[0], 16, System.Drawing.FontStyle.Bold,
                                                                    System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            TitleLabel.Font = font1;
        }

        ///======================================================================================================================
        ///  CodeMaid VSIX를 설치하는 메서드 ( VS 2019 )
        ///======================================================================================================================
        private void InstallCodeMaidButtonVS2019_Click(object sender, EventArgs e)
        {
            InstallCodeMaidButtonVS2019.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "CodeMaidVS2019.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  Sonar Lint VSIX를 설치하는 메서드 ( VS 2019 )
        ///======================================================================================================================
        private void InstallSonarLintButtonVS2019_Click(object sender, EventArgs e)
        {
            InstallSonarLintButtonVS2019.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "SonarLintVS2019.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  EditorGuidelines VSIX를 설치하는 메서드 ( VS 2019 )
        ///======================================================================================================================
        private void InstallGuidelinesButtonVS2019_Click(object sender, EventArgs e)
        {
            InstallGuidelinesButtonVS2019.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "GuidelinesVS2019.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  CodeMaid VSIX를 설치하는 메서드 ( VS 2022 )
        ///======================================================================================================================
        private void InstallCodeMaidButtonVS2022_Click(object sender, EventArgs e)
        {
            InstallCodeMaidButtonVS2022.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "CodeMaidVS2022.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  Sonar Lint VSIX를 설치하는 메서드 ( VS 2022 )
        ///======================================================================================================================
        private void InstallSonarLintButtonVS2022_Click(object sender, EventArgs e)
        {
            InstallSonarLintButtonVS2022.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "SonarLintVS2022.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  EditorGuidelines VSIX를 설치하는 메서드 ( VS 2022 )
        ///======================================================================================================================
        private void InstallGuidelinesButtonVS2022_Click(object sender, EventArgs e)
        {
            InstallGuidelinesButtonVS2022.Enabled = false;
            uiButtonTimer.Start();
            var startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(Application.StartupPath, "Resources", "Vsix", "GuidelinesVS2022.vsix")
            };
            Process.Start(startInfo);
        }

        ///======================================================================================================================
        ///  CodeMaid VSIX를 설치하는 메서드
        ///======================================================================================================================
        private void VsixInstallButtonEnableTimer(object? sender, EventArgs e)
        {
            InstallSonarLintButtonVS2019.Enabled = true;
            InstallCodeMaidButtonVS2019.Enabled = true;
            InstallGuidelinesButtonVS2019.Enabled = true;
            InstallSonarLintButtonVS2022.Enabled = true;
            InstallCodeMaidButtonVS2022.Enabled = true;
            InstallGuidelinesButtonVS2022.Enabled = true;
            uiButtonTimer.Stop();
        }

        ///======================================================================================================================
        ///  Unity 설치 디렉터리를 정하는 메서드
        ///======================================================================================================================
        private void OpenUnityEditorDirButton_Click(object sender, EventArgs e)
        {
            using var unityEditorPathSelectDialog = new CommonOpenFileDialog();
            unityEditorPathSelectDialog.IsFolderPicker = true;
            unityEditorPathSelectDialog.InitialDirectory = "C:\\Program Files\\Unity";
            if (unityEditorPathSelectDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                unityEditorRootPath = unityEditorPathSelectDialog.FileName;
                UnityEditorDirPathTextButton.Text = unityEditorRootPath;
            }
        }

        ///======================================================================================================================
        ///  코드 베이스 파일에 컨벤션을 적용하는 메서드
        ///======================================================================================================================
        private void CodebaseReplaceButton_Click(object sender, EventArgs e)
        {
            //===================================================================================================================
            //  Unity 설치 경로 확인
            //===================================================================================================================
            string installedEditorRootPath = Path.Combine(unityEditorRootPath, "Hub", "Editor");
            if (Directory.Exists(installedEditorRootPath) == false)
            {
                string tempPath = unityEditorRootPath;
                tempPath = tempPath.Replace('/', Path.DirectorySeparatorChar);
                tempPath = tempPath.Replace('\\', Path.DirectorySeparatorChar);

                string[] splitedPath = tempPath.Split(Path.DirectorySeparatorChar);
                string selectedFileName = splitedPath[^1];
                if (selectedFileName == "Unity")
                {
                    installedEditorRootPath = unityEditorRootPath;
                }
                else
                {
                    MessageBox.Show("올바르지 않은 Unity 설치 경로입니다.\r기본 경로 : \"C:\\Program Files\\Unity\"",
                                    "업데이트 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //===================================================================================================================
            //  복사할 파일이 있는지 확인
            //===================================================================================================================
            string sourceCodeBasePath = Path.Combine(Application.StartupPath, "Resources", "CodeBase", "Custom",
                                                    "81-C# Script-NewBehaviourScript.cs.txt");
            if (File.Exists(sourceCodeBasePath) == false)
            {
                MessageBox.Show("패치할 Code base 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "업데이트 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  결과 정리용 String Builder
            //===================================================================================================================
            var sb = new StringBuilder();
            sb.Append("\r\r적용된 파일 목록 : \r");
            int appliedFileCount = 0;
            try
            {
                //===============================================================================================================
                //  설치된 버전별로 돌면서 적용
                //===============================================================================================================
                string[] subdirectories = Directory.GetDirectories(installedEditorRootPath);
                foreach (string subdirectory in subdirectories)
                {
                    string destinationCodeBasePath =
                                                Path.Combine(subdirectory, "Editor", "Data", "Resources", "ScriptTemplates");
                    if (Directory.Exists(destinationCodeBasePath) == false)
                    {
                        MessageBox.Show($"올바르지 않은 Unity 에디터 설치 경로입니다.\r에러 경로:\"{destinationCodeBasePath}\"",
                                        "업데이트 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    destinationCodeBasePath = Path.Combine(destinationCodeBasePath, "81-C# Script-NewBehaviourScript.cs.txt");
                    if (File.Exists(destinationCodeBasePath) == true)
                    {
                        File.Delete(destinationCodeBasePath);
                    }
                    File.Copy(sourceCodeBasePath, destinationCodeBasePath);
                    sb.Append($"- {subdirectory}\r");
                    appliedFileCount++;
                }
            }
            //===================================================================================================================
            //  파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\rCode base 파일을 적용하는 중 문제가 발생했습니다." +
                                "\n관리자 권한으로도 실행해 보세요.",
                                "업데이트 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  문제 없이 끝난 경우, 메세지 박스 출력
            //===================================================================================================================
            string resultString = (appliedFileCount > 0) ? sb.ToString() : string.Empty;
            MessageBox.Show($"Code base를 컨벤션에 맞게 변경했습니다.{resultString}",
                            "업데이트 완료", MessageBoxButtons.OK);
        }

        ///======================================================================================================================
        ///  코드 베이스 파일에 컨벤션 적용 전으로 돌리는 메서드
        ///======================================================================================================================
        private void CodebaseRollbackButton_Click(object sender, EventArgs e)
        {
            //===================================================================================================================
            //  Unity 설치 경로 확인
            //===================================================================================================================
            string installedEditorRootPath = Path.Combine(unityEditorRootPath, "Hub", "Editor");
            if (Directory.Exists(installedEditorRootPath) == false)
            {
                string tempPath = unityEditorRootPath;
                tempPath = tempPath.Replace('/', Path.DirectorySeparatorChar);
                tempPath = tempPath.Replace('\\', Path.DirectorySeparatorChar);

                string[] splitedPath = tempPath.Split(Path.DirectorySeparatorChar);
                string selectedFileName = splitedPath[^1];
                if (selectedFileName == "Unity")
                {
                    installedEditorRootPath = unityEditorRootPath;
                }
                else
                {
                    MessageBox.Show("올바르지 않은 Unity 설치 경로입니다.\r기본 경로 : \"C:\\Program Files\\Unity\"",
                                    "롤백 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //===================================================================================================================
            //  복사할 파일이 있는지 확인
            //===================================================================================================================
            string sourceCodeBasePath = Path.Combine(Application.StartupPath, "Resources", "CodeBase", "Origin",
                                                    "81-C# Script-NewBehaviourScript.cs.txt");
            if (File.Exists(sourceCodeBasePath) == false)
            {
                MessageBox.Show("패치할 Code base 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "롤백 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  결과 정리용 String Builder
            //===================================================================================================================
            var sb = new StringBuilder();
            sb.Append("\r\r롤백된 파일 목록 : \r");
            int appliedFileCount = 0;
            try
            {
                //===============================================================================================================
                //  설치된 버전별로 돌면서 적용
                //===============================================================================================================
                string[] subdirectories = Directory.GetDirectories(installedEditorRootPath);
                foreach (string subdirectory in subdirectories)
                {
                    string destinationCodeBasePath =
                                                Path.Combine(subdirectory, "Editor", "Data", "Resources", "ScriptTemplates");
                    if (Directory.Exists(destinationCodeBasePath) == false)
                    {
                        MessageBox.Show($"올바르지 않은 Unity 에디터 설치 경로입니다.\r에러 경로:\"{destinationCodeBasePath}\"",
                                        "롤백 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    destinationCodeBasePath = Path.Combine(destinationCodeBasePath, "81-C# Script-NewBehaviourScript.cs.txt");
                    if (File.Exists(destinationCodeBasePath) == true)
                    {
                        File.Delete(destinationCodeBasePath);
                    }
                    File.Copy(sourceCodeBasePath, destinationCodeBasePath);
                    sb.Append($"- {subdirectory}\r");
                    appliedFileCount++;
                }
            }
            //===================================================================================================================
            //  파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\rCode base 파일을 적용하는 중 문제가 발생했습니다." +
                                "\n관리자 권한으로도 실행해 보세요.",
                                "롤백 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  문제 없이 끝난 경우, 메세지 박스 출력
            //===================================================================================================================
            string resultString = (appliedFileCount > 0) ? sb.ToString() : string.Empty;
            MessageBox.Show($"Code base를 원본으로 롤백했습니다.{resultString}", "롤백 완료", MessageBoxButtons.OK);
        }

        ///======================================================================================================================
        ///  Unity 프로젝트 디렉터리를 정하는 메서드
        ///======================================================================================================================
        private void OpenUnityProjectDirButton_Click(object sender, EventArgs e)
        {
            using var unityProjectPathSelectDialog = new CommonOpenFileDialog();
            unityProjectPathSelectDialog.IsFolderPicker = true;
            if (unityProjectPathSelectDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                unityProjectPath = unityProjectPathSelectDialog.FileName;
                UnityProjectDirPathTextButton.Text = unityProjectPath;
            }
        }

        ///======================================================================================================================
        ///  Unity 프로젝트에 컨벤션 설정 파일을 적용하는 메서드
        ///======================================================================================================================
        private void ApplyConventionButton_Click(object sender, EventArgs e)
        {
            var deleteFileName = new HashSet<string>();
            var updateFileName = new HashSet<string>();
            var createFileName = new HashSet<string>();

            //===================================================================================================================
            //  Unity 프로젝트 경로 확인 _ 디렉토리 존재 여부
            //===================================================================================================================
            if (Directory.Exists(unityProjectPath) == false)
            {
                MessageBox.Show("올바르지 않은 Unity 프로젝트 경로입니다.",
                                "컨벤션 적용 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  Unity 프로젝트 경로 확인 _ VS프로젝트 존재 여부
            //===================================================================================================================
            string[] slnFiles = Directory.GetFiles(unityProjectPath, "*.sln");
            if (slnFiles.Length == 0)
            {
                MessageBox.Show("올바르지 않은 Unity 프로젝트 경로입니다.",
                                "컨벤션 적용 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] splited = unityProjectPath.Split(Path.DirectorySeparatorChar);
            string projectName = splited[^1];

            //===================================================================================================================
            //  [컨벤션 설정] 복사할 파일이 있는지 확인
            //===================================================================================================================
            string sourceConfigFileRootPath = Path.Combine(Application.StartupPath, "Resources", "ConventionSettingFile");
            string[] configFiles = Directory.GetFiles(sourceConfigFileRootPath);
            if (configFiles.Length == 0)
            {
                MessageBox.Show("패치할 setting 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "컨벤션 적용 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // 새로 만들 파일들에 추가
                foreach (string file in configFiles)
                {
                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    createFileName.Add(fileName);
                }
            }

            try
            {
                //===============================================================================================================
                //  지정된 파일 개수만큼 반복
                //===============================================================================================================
                foreach (string file in configFiles)
                {
                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    string destinationSettingFilePath = Path.Combine(unityProjectPath, fileName);
                    if (File.Exists(destinationSettingFilePath) == true)
                    {
                        createFileName.Remove(fileName);
                        updateFileName.Add(fileName);
                        File.Delete(destinationSettingFilePath);
                    }
                    File.Copy(file, destinationSettingFilePath);
                }
            }
            //===================================================================================================================
            //  [컨벤션 설정] 파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\r컨벤션 설정 파일을 적용하는 중 문제가 발생했습니다.",
                                "컨벤션 세팅 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  [Github PR 템플릿 설정] 복사할 파일이 있는지 확인
            //===================================================================================================================
            var githubPRTemplateFileRootPath =
                                        Path.Combine(Application.StartupPath, "Resources", "ConventionSettingFile", ".github");
            var githubPRTemplateFiles = Directory.GetFiles(githubPRTemplateFileRootPath);
            if (githubPRTemplateFiles.Length == 0)
            {
                MessageBox.Show("패치할 github PR template 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "PR template 적용 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // 새로 만들 파일들에 추가
                foreach (string file in githubPRTemplateFiles)
                {
                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    createFileName.Add(fileName);
                }
            }

            try
            {
                //===============================================================================================================
                //  지정된 파일 개수만큼 반복
                //===============================================================================================================
                foreach (string file in githubPRTemplateFiles)
                {
                    var destinationDirPath = Path.Combine(unityProjectPath, ".github");
                    if (Directory.Exists(destinationDirPath) == false)
                    {
                        Directory.CreateDirectory(destinationDirPath);
                    }

                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    string destinationSettingFilePath = Path.Combine(destinationDirPath, fileName);
                    if (File.Exists(destinationSettingFilePath) == true)
                    {
                        createFileName.Remove(fileName);
                        updateFileName.Add(fileName);
                        File.Delete(destinationSettingFilePath);
                    }
                    File.Copy(file, destinationSettingFilePath);
                }
            }
            //===================================================================================================================
            //  [Github PR 템플릿 설정] 파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\rGithub PR Template 파일을 적용하는 중 문제가 발생했습니다.",
                                "PR Template 세팅 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  [Azure PR 템플릿 설정] 복사할 파일이 있는지 확인
            //===================================================================================================================
            var azurePRTemplateFileRootPath =
                                    Path.Combine(Application.StartupPath, "Resources", "ConventionSettingFile", ".azuredevops");
            var azurePRTemplateFiles = Directory.GetFiles(azurePRTemplateFileRootPath);
            if (azurePRTemplateFiles.Length == 0)
            {
                MessageBox.Show("패치할 azure PR template 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "PR template 적용 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // 새로 만들 파일들에 추가
                foreach (string file in azurePRTemplateFiles)
                {
                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    createFileName.Add(fileName);
                }
            }

            try
            {
                //===============================================================================================================
                //  지정된 파일 개수만큼 반복
                //===============================================================================================================
                foreach (string file in azurePRTemplateFiles)
                {
                    var destinationDirPath = Path.Combine(unityProjectPath, ".azuredevops");
                    if (Directory.Exists(destinationDirPath) == false)
                    {
                        Directory.CreateDirectory(destinationDirPath);
                    }

                    splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    string destinationSettingFilePath = Path.Combine(destinationDirPath, fileName);
                    if (File.Exists(destinationSettingFilePath) == true)
                    {
                        createFileName.Remove(fileName);
                        updateFileName.Add(fileName);
                        File.Delete(destinationSettingFilePath);
                    }
                    File.Copy(file, destinationSettingFilePath);
                }
            }
            //===================================================================================================================
            //  [Azure PR 템플릿 설정] 파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\rGithub PR Template 파일을 적용하는 중 문제가 발생했습니다.",
                                "PR Template 세팅 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  문제 없이 끝난 경우, 메세지 박스 출력
            //===================================================================================================================
            string resultString = CreateResultString(createFileName, deleteFileName, updateFileName);
            MessageBox.Show($"프로젝트 {projectName}에\r컨벤션 설정 파일및 PR 템플릿 적용이 완료되었습니다.\r\r{resultString}",
                            "세팅 완료", MessageBoxButtons.OK);
        }

        ///======================================================================================================================
        ///  Snippet 코드를 저장할 디렉터리를 정하는 메서드
        ///======================================================================================================================
        private void OpenSnippetSavePathButton_Click(object sender, EventArgs e)
        {
            using var snippetSavePathSelectDialog = new CommonOpenFileDialog();
            snippetSavePathSelectDialog.IsFolderPicker = true;
            if (snippetSavePathSelectDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                snippetSavePath = snippetSavePathSelectDialog.FileName;
                SnippetSavePathTextBox.Text = snippetSavePath;
            }
        }

        ///======================================================================================================================
        ///  Snippet 코드를 업데이트 하는 메서드
        ///======================================================================================================================
        private void UpdateSnippetButton_Click(object sender, EventArgs e)
        {
            var deleteFileName = new HashSet<string>();
            var updateFileName = new HashSet<string>();
            var createFileName = new HashSet<string>();

            //===================================================================================================================
            //  Snippet 프로젝트 경로 확인
            //===================================================================================================================
            if (Directory.Exists(snippetSavePath) == false)
            {
                MessageBox.Show("올바르지 않은 Unity 프로젝트 경로입니다.",
                                "스니펫 적용 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  기존 스니펫 모두 제거
            //===================================================================================================================
            string[] currentSnippetFiles = Directory.GetFiles(snippetSavePath);
            foreach (string file in currentSnippetFiles)
            {
                try
                {
                    string[] splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];
                    deleteFileName.Add(fileName);
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    MessageBox.Show($"{ex.Message}\r\r기존 스니펫 파일을 정리하는 중 문제가 발생했습니다.\r" +
                                    $"관리자 권한으로도 실행해 보세요.",
                                    "스니펫 적용 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //===================================================================================================================
            //  복사할 파일이 있는지 확인
            //===================================================================================================================
            string sourceSnippetFileRootPath = Path.Combine(Application.StartupPath, "Resources", "Snippets");
            string[] snippetFiles = Directory.GetFiles(sourceSnippetFileRootPath);
            if (snippetFiles.Length == 0)
            {
                MessageBox.Show("패치할 setting 파일이 없습니다.\r리소스 폴더에 파일이 있는지 확인하세요.",
                                "스니펫 적용 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //===============================================================================================================
                //  지정된 파일 개수만큼 반복
                //===============================================================================================================
                foreach (string file in snippetFiles)
                {
                    string[] splited = file.Split(Path.DirectorySeparatorChar);
                    string fileName = splited[^1];

                    if (deleteFileName.Contains(fileName) == true)
                    {
                        deleteFileName.Remove(fileName);
                        updateFileName.Add(fileName);
                    }
                    else
                    {
                        createFileName.Add(fileName);
                    }

                    string destinationSettingFilePath = Path.Combine(snippetSavePath, fileName);
                    if (File.Exists(destinationSettingFilePath) == true)
                    {
                        File.Delete(destinationSettingFilePath);
                    }
                    File.Copy(file, destinationSettingFilePath);
                }
            }
            //===================================================================================================================
            //  파일 복사에 실패한 경우
            //===================================================================================================================
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\r스니펫 파일을 적용하는 중 문제가 발생했습니다.",
                                "스니펫 적용 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //===================================================================================================================
            //  문제 없이 끝난 경우, 메세지 박스 출력
            //===================================================================================================================
            string resultString = CreateResultString(createFileName, deleteFileName, updateFileName);
            MessageBox.Show($"스니펫 파일 적용이 완료되었습니다.\r\r{resultString}",
                            "스니펫 세팅 완료", MessageBoxButtons.OK);
        }

        ///======================================================================================================================
        ///  스니펫에 대한 튜토리얼을 여는 메서드
        ///======================================================================================================================
        private void SnippetWikiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://learn.microsoft.com/ko-kr/visualstudio/ide/walkthrough-creating-a-code-snippet?view=vs-2022",
                UseShellExecute = true
            });
        }

        ///======================================================================================================================
        ///  스니펫을 사용하는 방법에대한 가이드를 여는 메서드
        ///======================================================================================================================
        private void SnippetGuideLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/KimYC1223/ConventionWizardForUnity/wiki",
                UseShellExecute = true
            });
        }

        ///======================================================================================================================
        ///  컨벤션 페이지를 여는 메서드
        ///======================================================================================================================
        private void CheckConventionLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/KimYC1223/ConventionWizardForUnity/wiki" +
                          "/Convention-Wizard-For-Unity-%EC%BD%94%EB%93%9C-%EC%BB%A8%EB%B2%A4%EC%85%98",
                UseShellExecute = true
            });
        }

        ///======================================================================================================================
        ///  개발자 블로그를 여는 메서드
        ///======================================================================================================================
        private void OpenBlogButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://kimyc1223.github.io/",
                UseShellExecute = true
            });
        }

        ///======================================================================================================================
        ///  개발자 블로그를 여는 메서드
        ///======================================================================================================================
        private void OpenGithubButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/KimYC1223/ConventionWizardForUnity/releases/",
                UseShellExecute = true
            });
        }

        ///======================================================================================================================
        ///  Convention Wizard 컨벤션 툴을 여는 메서드
        ///======================================================================================================================
        private void CustomToolButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        ///======================================================================================================================
        ///  Convention Wizard For Unity의 Resources가 설치된 디렉토리 열기
        ///======================================================================================================================
        private void ResourceDirOpenButton_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath, "Resources").Replace('/', Path.DirectorySeparatorChar));
        }

        ///======================================================================================================================
        ///  결과 정리용 String 을 만드는 메서드
        ///======================================================================================================================
        private string CreateResultString(HashSet<string> createFileName, HashSet<string> deleteFileName,
                                            HashSet<string> updateFileName)
        {
            // 변수 선언 및 초기화
            string resultString = string.Empty;
            var resultSB = new StringBuilder();
            StringBuilder createFileSB;
            StringBuilder deleteFileSB;
            StringBuilder updateFileSB;
            var sbList = new List<StringBuilder>();

            // 새로 추가된 파일 목록
            if (createFileName.Count > 0)
            {
                createFileSB = new StringBuilder();
                createFileSB.Append("생성된 파일 목록 : \r");
                foreach (string file in createFileName)
                {
                    createFileSB.Append($"- {file}\r");
                }
                sbList.Add(createFileSB);
            }

            // 제거된 파일 목록
            if (deleteFileName.Count > 0)
            {
                deleteFileSB = new StringBuilder();
                deleteFileSB.Append("제거된 파일 목록 : \r");
                foreach (string file in deleteFileName)
                {
                    deleteFileSB.Append($"- {file}\r");
                }
                sbList.Add(deleteFileSB);
            }

            //  업데이트된 파일 목록
            if (updateFileName.Count > 0)
            {
                updateFileSB = new StringBuilder();
                updateFileSB.Append("업데이트된 파일 목록 : \r");
                foreach (string file in updateFileName)
                {
                    updateFileSB.Append($"- {file}\r");
                }
                sbList.Add(updateFileSB);
            }

            for (int i = 0; i < sbList.Count; i++)
            {
                resultSB.Append(sbList[i]);
                if (i < sbList.Count - 1)
                {
                    resultSB.Append('\r');
                }
            }

            if (sbList.Count > 0)
            {
                resultString = resultSB.ToString();
            }

            return resultString;
        }
    }
}