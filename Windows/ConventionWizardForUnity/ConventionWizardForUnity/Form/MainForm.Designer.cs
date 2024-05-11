namespace ConventionWizardForUnity
{
    partial class MainForm
    {
        #region MEMBER_FIELD
        // ======================================================================================================================
        //  WIN FORM UI OBJECT 모음
        // ======================================================================================================================
        #region UI_OBJECTS
        private Button InstallGuidelinesButtonVS2022;
        private Button InstallGuidelinesButtonVS2019;
        private Button InstallSonarLintButtonVS2022;
        private Button InstallCodeMaidButtonVS2022;
        private Button InstallSonarLintButtonVS2019;
        private Button InstallCodeMaidButtonVS2019;
        private Label TitleLabel;
        private PictureBox IconViewer;
        private Label TitleSubLabel;
        private Panel HR_1;
        private GroupBox VsixInstallGroup;
        private GroupBox CodeBaseInstallGroup;
        private Label CodeBaseInstallDescLabel_2;
        private Label CodeBaseInstallDescLabel_1;
        private Label UnityEditorPathLabel;
        private TextBox UnityEditorDirPathTextButton;
        private GroupBox ApplyConventionSettingGroupBox;
        private Label ApplyConventionSettingDescLabel_2;
        private Label ApplyConventionSettingDescLabel_1;
        private Label UnityProjectPathLabel;
        private TextBox UnityProjectDirPathTextButton;
        private Label CodeBaseInstallGuideLabel;
        private Label ApplyConventionSettingGuideLabel_2;
        private Label VersionLabel;
        private Label ApplyConventionSettingGuideLabel_1;
        private GroupBox SnippetInstallGroupBox;
        private Label SnippetInstallDescLabel_1;
        private Label SnippetSavePathLabel;
        private TextBox SnippetSavePathTextBox;
        private Button ApplyConventionButton;
        private Panel HR_2;
        private Panel HR_3;
        private Panel HR_4;
        #endregion

        // ======================================================================================================================
        //  PRIVATE 멤버 변수
        // ======================================================================================================================
        private System.ComponentModel.IContainer components = null;                         // 필수 디자이너 변수입니다.
        #endregion MEMBER_FIELD

        #region PRIVATE_METHOD
        // ======================================================================================================================
        //  디자이너 지원에 필요한 메서드입니다. 
        // ======================================================================================================================
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// </summary>
        private void InitializeComponent()
        {
            Button OpenUnityEditorDirButton;
            Button CodebaseReplaceButton;
            Button CodebaseRollbackButton;
            Button OpenUnityProjectDirButton;
            Button OpenSnippetSavePathButton;
            Button UpdateSnippetButton;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ApplyConventionButton = new Button();
            TitleLabel = new Label();
            IconViewer = new PictureBox();
            TitleSubLabel = new Label();
            HR_1 = new Panel();
            VsixInstallGroup = new GroupBox();
            InstallGuidelinesButtonVS2022 = new Button();
            InstallGuidelinesButtonVS2019 = new Button();
            InstallSonarLintButtonVS2022 = new Button();
            InstallCodeMaidButtonVS2022 = new Button();
            InstallSonarLintButtonVS2019 = new Button();
            InstallCodeMaidButtonVS2019 = new Button();
            CodeBaseInstallGroup = new GroupBox();
            CodeBaseInstallGuideLabel = new Label();
            CodeBaseInstallDescLabel_2 = new Label();
            CodeBaseInstallDescLabel_1 = new Label();
            UnityEditorPathLabel = new Label();
            UnityEditorDirPathTextButton = new TextBox();
            ApplyConventionSettingGroupBox = new GroupBox();
            CheckConventionLabel = new LinkLabel();
            ApplyConventionSettingGuideLabel_1 = new Label();
            ApplyConventionSettingGuideLabel_2 = new Label();
            ApplyConventionSettingDescLabel_2 = new Label();
            ApplyConventionSettingDescLabel_1 = new Label();
            UnityProjectPathLabel = new Label();
            UnityProjectDirPathTextButton = new TextBox();
            VersionLabel = new Label();
            SnippetInstallGroupBox = new GroupBox();
            SnippetGuideLinkLabel = new LinkLabel();
            SnippetWikiLinkLabel = new LinkLabel();
            SnippetInstallDescLabel_1 = new Label();
            SnippetSavePathLabel = new Label();
            SnippetSavePathTextBox = new TextBox();
            HR_2 = new Panel();
            HR_3 = new Panel();
            HR_4 = new Panel();
            TeamNameLabel = new Label();
            menuStrip1 = new MenuStrip();
            FileMenuButton = new ToolStripMenuItem();
            ResourceDirOpenButton = new ToolStripMenuItem();
            ToolMenuButton = new ToolStripMenuItem();
            CustomToolButton = new ToolStripMenuItem();
            HelpMenuButton = new ToolStripMenuItem();
            OpenGithubButton = new ToolStripMenuItem();
            OpenBlogButton = new ToolStripMenuItem();
            OpenUnityEditorDirButton = new Button();
            CodebaseReplaceButton = new Button();
            CodebaseRollbackButton = new Button();
            OpenUnityProjectDirButton = new Button();
            OpenSnippetSavePathButton = new Button();
            UpdateSnippetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IconViewer).BeginInit();
            VsixInstallGroup.SuspendLayout();
            CodeBaseInstallGroup.SuspendLayout();
            ApplyConventionSettingGroupBox.SuspendLayout();
            SnippetInstallGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenUnityEditorDirButton
            // 
            OpenUnityEditorDirButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OpenUnityEditorDirButton.Location = new Point(350, 68);
            OpenUnityEditorDirButton.Margin = new Padding(3, 4, 3, 4);
            OpenUnityEditorDirButton.Name = "OpenUnityEditorDirButton";
            OpenUnityEditorDirButton.Size = new Size(77, 24);
            OpenUnityEditorDirButton.TabIndex = 14;
            OpenUnityEditorDirButton.Text = "찾기";
            OpenUnityEditorDirButton.UseVisualStyleBackColor = true;
            OpenUnityEditorDirButton.Click += OpenUnityEditorDirButton_Click;
            // 
            // CodebaseReplaceButton
            // 
            CodebaseReplaceButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CodebaseReplaceButton.Location = new Point(230, 99);
            CodebaseReplaceButton.Margin = new Padding(3, 4, 3, 4);
            CodebaseReplaceButton.Name = "CodebaseReplaceButton";
            CodebaseReplaceButton.Size = new Size(197, 24);
            CodebaseReplaceButton.TabIndex = 13;
            CodebaseReplaceButton.Text = "코드베이스 변경";
            CodebaseReplaceButton.UseVisualStyleBackColor = true;
            CodebaseReplaceButton.Click += CodebaseReplaceButton_Click;
            // 
            // CodebaseRollbackButton
            // 
            CodebaseRollbackButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CodebaseRollbackButton.Location = new Point(15, 99);
            CodebaseRollbackButton.Margin = new Padding(3, 4, 3, 4);
            CodebaseRollbackButton.Name = "CodebaseRollbackButton";
            CodebaseRollbackButton.Size = new Size(197, 24);
            CodebaseRollbackButton.TabIndex = 4;
            CodebaseRollbackButton.Text = "원복시키기";
            CodebaseRollbackButton.UseVisualStyleBackColor = true;
            CodebaseRollbackButton.Click += CodebaseRollbackButton_Click;
            // 
            // OpenUnityProjectDirButton
            // 
            OpenUnityProjectDirButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OpenUnityProjectDirButton.Location = new Point(350, 62);
            OpenUnityProjectDirButton.Margin = new Padding(3, 4, 3, 4);
            OpenUnityProjectDirButton.Name = "OpenUnityProjectDirButton";
            OpenUnityProjectDirButton.Size = new Size(77, 24);
            OpenUnityProjectDirButton.TabIndex = 14;
            OpenUnityProjectDirButton.Text = "찾기";
            OpenUnityProjectDirButton.UseVisualStyleBackColor = true;
            OpenUnityProjectDirButton.Click += OpenUnityProjectDirButton_Click;
            // 
            // OpenSnippetSavePathButton
            // 
            OpenSnippetSavePathButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OpenSnippetSavePathButton.Location = new Point(350, 46);
            OpenSnippetSavePathButton.Margin = new Padding(3, 4, 3, 4);
            OpenSnippetSavePathButton.Name = "OpenSnippetSavePathButton";
            OpenSnippetSavePathButton.Size = new Size(77, 24);
            OpenSnippetSavePathButton.TabIndex = 14;
            OpenSnippetSavePathButton.Text = "찾기";
            OpenSnippetSavePathButton.UseVisualStyleBackColor = true;
            OpenSnippetSavePathButton.Click += OpenSnippetSavePathButton_Click;
            // 
            // UpdateSnippetButton
            // 
            UpdateSnippetButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UpdateSnippetButton.Location = new Point(16, 79);
            UpdateSnippetButton.Margin = new Padding(3, 4, 3, 4);
            UpdateSnippetButton.Name = "UpdateSnippetButton";
            UpdateSnippetButton.Size = new Size(412, 24);
            UpdateSnippetButton.TabIndex = 13;
            UpdateSnippetButton.Text = "C# 코드 스니펫 다운로드 및 업데이트";
            UpdateSnippetButton.UseVisualStyleBackColor = true;
            UpdateSnippetButton.Click += UpdateSnippetButton_Click;
            // 
            // ApplyConventionButton
            // 
            ApplyConventionButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApplyConventionButton.Location = new Point(15, 94);
            ApplyConventionButton.Margin = new Padding(3, 4, 3, 4);
            ApplyConventionButton.Name = "ApplyConventionButton";
            ApplyConventionButton.Size = new Size(412, 24);
            ApplyConventionButton.TabIndex = 13;
            ApplyConventionButton.Text = "Unity 프로젝트에 코드 컨벤션 적용";
            ApplyConventionButton.UseVisualStyleBackColor = true;
            ApplyConventionButton.Click += ApplyConventionButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("D2Coding", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(122, 38);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(280, 24);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Convention Wizard For Unity";
            // 
            // IconViewer
            // 
            IconViewer.Image = Properties.Resources.Icon;
            IconViewer.Location = new Point(19, 38);
            IconViewer.Margin = new Padding(3, 4, 3, 4);
            IconViewer.Name = "IconViewer";
            IconViewer.Size = new Size(100, 100);
            IconViewer.SizeMode = PictureBoxSizeMode.StretchImage;
            IconViewer.TabIndex = 1;
            IconViewer.TabStop = false;
            // 
            // TitleSubLabel
            // 
            TitleSubLabel.AutoSize = true;
            TitleSubLabel.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TitleSubLabel.Location = new Point(136, 112);
            TitleSubLabel.Name = "TitleSubLabel";
            TitleSubLabel.Size = new Size(310, 12);
            TitleSubLabel.TabIndex = 4;
            TitleSubLabel.Text = "Unity / C# 용 코드 컨벤션 유지를 위한 환경 설정 도우미";
            // 
            // HR_1
            // 
            HR_1.BorderStyle = BorderStyle.Fixed3D;
            HR_1.Location = new Point(28, 140);
            HR_1.Margin = new Padding(3, 4, 3, 4);
            HR_1.Name = "HR_1";
            HR_1.Size = new Size(442, 4);
            HR_1.TabIndex = 6;
            // 
            // VsixInstallGroup
            // 
            VsixInstallGroup.BackgroundImageLayout = ImageLayout.None;
            VsixInstallGroup.Controls.Add(InstallGuidelinesButtonVS2022);
            VsixInstallGroup.Controls.Add(InstallGuidelinesButtonVS2019);
            VsixInstallGroup.Controls.Add(InstallSonarLintButtonVS2022);
            VsixInstallGroup.Controls.Add(InstallCodeMaidButtonVS2022);
            VsixInstallGroup.Controls.Add(InstallSonarLintButtonVS2019);
            VsixInstallGroup.Controls.Add(InstallCodeMaidButtonVS2019);
            VsixInstallGroup.Location = new Point(28, 154);
            VsixInstallGroup.Margin = new Padding(3, 4, 3, 4);
            VsixInstallGroup.Name = "VsixInstallGroup";
            VsixInstallGroup.Padding = new Padding(3, 4, 3, 4);
            VsixInstallGroup.Size = new Size(442, 124);
            VsixInstallGroup.TabIndex = 7;
            VsixInstallGroup.TabStop = false;
            VsixInstallGroup.Text = "Visual Studio용 VSIX 설치";
            // 
            // InstallGuidelinesButtonVS2022
            // 
            InstallGuidelinesButtonVS2022.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallGuidelinesButtonVS2022.Location = new Point(227, 86);
            InstallGuidelinesButtonVS2022.Margin = new Padding(3, 4, 3, 4);
            InstallGuidelinesButtonVS2022.Name = "InstallGuidelinesButtonVS2022";
            InstallGuidelinesButtonVS2022.Size = new Size(200, 24);
            InstallGuidelinesButtonVS2022.TabIndex = 8;
            InstallGuidelinesButtonVS2022.Text = "Guidelines 설치 (VS2022)";
            InstallGuidelinesButtonVS2022.UseVisualStyleBackColor = true;
            InstallGuidelinesButtonVS2022.Click += InstallGuidelinesButtonVS2022_Click;
            // 
            // InstallGuidelinesButtonVS2019
            // 
            InstallGuidelinesButtonVS2019.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallGuidelinesButtonVS2019.Location = new Point(15, 86);
            InstallGuidelinesButtonVS2019.Margin = new Padding(3, 4, 3, 4);
            InstallGuidelinesButtonVS2019.Name = "InstallGuidelinesButtonVS2019";
            InstallGuidelinesButtonVS2019.Size = new Size(200, 24);
            InstallGuidelinesButtonVS2019.TabIndex = 7;
            InstallGuidelinesButtonVS2019.Text = "Guidelines 설치 (VS2019)";
            InstallGuidelinesButtonVS2019.UseVisualStyleBackColor = true;
            InstallGuidelinesButtonVS2019.Click += InstallGuidelinesButtonVS2019_Click;
            // 
            // InstallSonarLintButtonVS2022
            // 
            InstallSonarLintButtonVS2022.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallSonarLintButtonVS2022.Location = new Point(227, 56);
            InstallSonarLintButtonVS2022.Margin = new Padding(3, 4, 3, 4);
            InstallSonarLintButtonVS2022.Name = "InstallSonarLintButtonVS2022";
            InstallSonarLintButtonVS2022.Size = new Size(200, 24);
            InstallSonarLintButtonVS2022.TabIndex = 6;
            InstallSonarLintButtonVS2022.Text = "SonarLint 설치 (VS2022)";
            InstallSonarLintButtonVS2022.UseVisualStyleBackColor = true;
            InstallSonarLintButtonVS2022.Click += InstallSonarLintButtonVS2022_Click;
            // 
            // InstallCodeMaidButtonVS2022
            // 
            InstallCodeMaidButtonVS2022.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallCodeMaidButtonVS2022.Location = new Point(227, 26);
            InstallCodeMaidButtonVS2022.Margin = new Padding(3, 4, 3, 4);
            InstallCodeMaidButtonVS2022.Name = "InstallCodeMaidButtonVS2022";
            InstallCodeMaidButtonVS2022.Size = new Size(200, 24);
            InstallCodeMaidButtonVS2022.TabIndex = 5;
            InstallCodeMaidButtonVS2022.Text = "CodeMaid 설치 (VS2022)";
            InstallCodeMaidButtonVS2022.UseVisualStyleBackColor = true;
            InstallCodeMaidButtonVS2022.Click += InstallCodeMaidButtonVS2022_Click;
            // 
            // InstallSonarLintButtonVS2019
            // 
            InstallSonarLintButtonVS2019.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallSonarLintButtonVS2019.Location = new Point(15, 56);
            InstallSonarLintButtonVS2019.Margin = new Padding(3, 4, 3, 4);
            InstallSonarLintButtonVS2019.Name = "InstallSonarLintButtonVS2019";
            InstallSonarLintButtonVS2019.Size = new Size(200, 24);
            InstallSonarLintButtonVS2019.TabIndex = 4;
            InstallSonarLintButtonVS2019.Text = "SonarLint 설치 (VS2019)";
            InstallSonarLintButtonVS2019.UseVisualStyleBackColor = true;
            InstallSonarLintButtonVS2019.Click += InstallSonarLintButtonVS2019_Click;
            // 
            // InstallCodeMaidButtonVS2019
            // 
            InstallCodeMaidButtonVS2019.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InstallCodeMaidButtonVS2019.Location = new Point(15, 26);
            InstallCodeMaidButtonVS2019.Margin = new Padding(3, 4, 3, 4);
            InstallCodeMaidButtonVS2019.Name = "InstallCodeMaidButtonVS2019";
            InstallCodeMaidButtonVS2019.Size = new Size(200, 24);
            InstallCodeMaidButtonVS2019.TabIndex = 3;
            InstallCodeMaidButtonVS2019.Text = "CodeMaid 설치 (VS2019)";
            InstallCodeMaidButtonVS2019.UseVisualStyleBackColor = true;
            InstallCodeMaidButtonVS2019.Click += InstallCodeMaidButtonVS2019_Click;
            // 
            // CodeBaseInstallGroup
            // 
            CodeBaseInstallGroup.BackgroundImageLayout = ImageLayout.None;
            CodeBaseInstallGroup.Controls.Add(CodeBaseInstallGuideLabel);
            CodeBaseInstallGroup.Controls.Add(OpenUnityEditorDirButton);
            CodeBaseInstallGroup.Controls.Add(CodebaseReplaceButton);
            CodeBaseInstallGroup.Controls.Add(CodeBaseInstallDescLabel_2);
            CodeBaseInstallGroup.Controls.Add(CodeBaseInstallDescLabel_1);
            CodeBaseInstallGroup.Controls.Add(UnityEditorPathLabel);
            CodeBaseInstallGroup.Controls.Add(UnityEditorDirPathTextButton);
            CodeBaseInstallGroup.Controls.Add(CodebaseRollbackButton);
            CodeBaseInstallGroup.Location = new Point(28, 302);
            CodeBaseInstallGroup.Margin = new Padding(3, 4, 3, 4);
            CodeBaseInstallGroup.Name = "CodeBaseInstallGroup";
            CodeBaseInstallGroup.Padding = new Padding(3, 4, 3, 4);
            CodeBaseInstallGroup.Size = new Size(442, 164);
            CodeBaseInstallGroup.TabIndex = 9;
            CodeBaseInstallGroup.TabStop = false;
            CodeBaseInstallGroup.Text = "Unity 코드 베이스 수정하기";
            // 
            // CodeBaseInstallGuideLabel
            // 
            CodeBaseInstallGuideLabel.AutoSize = true;
            CodeBaseInstallGuideLabel.ForeColor = Color.Teal;
            CodeBaseInstallGuideLabel.Location = new Point(13, 133);
            CodeBaseInstallGuideLabel.Name = "CodeBaseInstallGuideLabel";
            CodeBaseInstallGuideLabel.Size = new Size(236, 15);
            CodeBaseInstallGuideLabel.TabIndex = 15;
            CodeBaseInstallGuideLabel.Text = "기본 값은 C:\\Program Files\\Unity 입니다.";
            // 
            // CodeBaseInstallDescLabel_2
            // 
            CodeBaseInstallDescLabel_2.AutoSize = true;
            CodeBaseInstallDescLabel_2.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBaseInstallDescLabel_2.ForeColor = Color.Gray;
            CodeBaseInstallDescLabel_2.Location = new Point(13, 47);
            CodeBaseInstallDescLabel_2.Name = "CodeBaseInstallDescLabel_2";
            CodeBaseInstallDescLabel_2.Size = new Size(367, 11);
            CodeBaseInstallDescLabel_2.TabIndex = 12;
            CodeBaseInstallDescLabel_2.Text = "되도록 하는 기능입니다. (프로젝트에 상관없이 에디터 버전에 전체 적용)";
            // 
            // CodeBaseInstallDescLabel_1
            // 
            CodeBaseInstallDescLabel_1.AutoSize = true;
            CodeBaseInstallDescLabel_1.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBaseInstallDescLabel_1.ForeColor = Color.Gray;
            CodeBaseInstallDescLabel_1.Location = new Point(13, 28);
            CodeBaseInstallDescLabel_1.Name = "CodeBaseInstallDescLabel_1";
            CodeBaseInstallDescLabel_1.Size = new Size(377, 11);
            CodeBaseInstallDescLabel_1.TabIndex = 11;
            CodeBaseInstallDescLabel_1.Text = "Unity Editor에서, 새로운 C# 파일을 만들 때 자동으로 코드 스타일이 적용";
            // 
            // UnityEditorPathLabel
            // 
            UnityEditorPathLabel.AutoSize = true;
            UnityEditorPathLabel.Location = new Point(13, 73);
            UnityEditorPathLabel.Name = "UnityEditorPathLabel";
            UnityEditorPathLabel.Size = new Size(126, 15);
            UnityEditorPathLabel.TabIndex = 10;
            UnityEditorPathLabel.Text = "Unity Editor 설치 경로";
            // 
            // UnityEditorDirPathTextButton
            // 
            UnityEditorDirPathTextButton.BorderStyle = BorderStyle.FixedSingle;
            UnityEditorDirPathTextButton.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UnityEditorDirPathTextButton.Location = new Point(147, 70);
            UnityEditorDirPathTextButton.Margin = new Padding(0);
            UnityEditorDirPathTextButton.Name = "UnityEditorDirPathTextButton";
            UnityEditorDirPathTextButton.ReadOnly = true;
            UnityEditorDirPathTextButton.Size = new Size(197, 20);
            UnityEditorDirPathTextButton.TabIndex = 5;
            UnityEditorDirPathTextButton.Text = "C:\\Program Files\\Unity";
            // 
            // ApplyConventionSettingGroupBox
            // 
            ApplyConventionSettingGroupBox.BackgroundImageLayout = ImageLayout.None;
            ApplyConventionSettingGroupBox.Controls.Add(CheckConventionLabel);
            ApplyConventionSettingGroupBox.Controls.Add(ApplyConventionSettingGuideLabel_1);
            ApplyConventionSettingGroupBox.Controls.Add(ApplyConventionSettingGuideLabel_2);
            ApplyConventionSettingGroupBox.Controls.Add(OpenUnityProjectDirButton);
            ApplyConventionSettingGroupBox.Controls.Add(ApplyConventionButton);
            ApplyConventionSettingGroupBox.Controls.Add(ApplyConventionSettingDescLabel_2);
            ApplyConventionSettingGroupBox.Controls.Add(ApplyConventionSettingDescLabel_1);
            ApplyConventionSettingGroupBox.Controls.Add(UnityProjectPathLabel);
            ApplyConventionSettingGroupBox.Controls.Add(UnityProjectDirPathTextButton);
            ApplyConventionSettingGroupBox.Location = new Point(28, 490);
            ApplyConventionSettingGroupBox.Margin = new Padding(3, 4, 3, 4);
            ApplyConventionSettingGroupBox.Name = "ApplyConventionSettingGroupBox";
            ApplyConventionSettingGroupBox.Padding = new Padding(3, 4, 3, 4);
            ApplyConventionSettingGroupBox.Size = new Size(442, 207);
            ApplyConventionSettingGroupBox.TabIndex = 15;
            ApplyConventionSettingGroupBox.TabStop = false;
            ApplyConventionSettingGroupBox.Text = "Unity 코드 컨벤션 설정 파일 적용";
            // 
            // CheckConventionLabel
            // 
            CheckConventionLabel.AutoSize = true;
            CheckConventionLabel.Location = new Point(13, 174);
            CheckConventionLabel.Name = "CheckConventionLabel";
            CheckConventionLabel.Size = new Size(147, 15);
            CheckConventionLabel.TabIndex = 18;
            CheckConventionLabel.TabStop = true;
            CheckConventionLabel.Text = "코드 컨벤션 확인하러가기";
            CheckConventionLabel.LinkClicked += CheckConventionLabel_LinkClicked;
            // 
            // ApplyConventionSettingGuideLabel_1
            // 
            ApplyConventionSettingGuideLabel_1.AutoSize = true;
            ApplyConventionSettingGuideLabel_1.ForeColor = Color.Teal;
            ApplyConventionSettingGuideLabel_1.Location = new Point(13, 150);
            ApplyConventionSettingGuideLabel_1.Name = "ApplyConventionSettingGuideLabel_1";
            ApplyConventionSettingGuideLabel_1.Size = new Size(359, 15);
            ApplyConventionSettingGuideLabel_1.TabIndex = 16;
            ApplyConventionSettingGuideLabel_1.Text = "만들거나, 업데이트를 적용하고나서, 최초 1회만 적용하면 됩니다.";
            // 
            // ApplyConventionSettingGuideLabel_2
            // 
            ApplyConventionSettingGuideLabel_2.AutoSize = true;
            ApplyConventionSettingGuideLabel_2.ForeColor = Color.Teal;
            ApplyConventionSettingGuideLabel_2.Location = new Point(13, 130);
            ApplyConventionSettingGuideLabel_2.Name = "ApplyConventionSettingGuideLabel_2";
            ApplyConventionSettingGuideLabel_2.Size = new Size(397, 15);
            ApplyConventionSettingGuideLabel_2.TabIndex = 15;
            ApplyConventionSettingGuideLabel_2.Text = "프로젝트의 sln 파일이 있는 위치를 설정하시면 됩니다. 신규 프로젝트를 ";
            // 
            // ApplyConventionSettingDescLabel_2
            // 
            ApplyConventionSettingDescLabel_2.AutoSize = true;
            ApplyConventionSettingDescLabel_2.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ApplyConventionSettingDescLabel_2.ForeColor = Color.Gray;
            ApplyConventionSettingDescLabel_2.Location = new Point(13, 44);
            ApplyConventionSettingDescLabel_2.Name = "ApplyConventionSettingDescLabel_2";
            ApplyConventionSettingDescLabel_2.Size = new Size(216, 11);
            ApplyConventionSettingDescLabel_2.TabIndex = 12;
            ApplyConventionSettingDescLabel_2.Text = "(에디터 버전에 상관없이 프로젝트에 적용)";
            // 
            // ApplyConventionSettingDescLabel_1
            // 
            ApplyConventionSettingDescLabel_1.AutoSize = true;
            ApplyConventionSettingDescLabel_1.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ApplyConventionSettingDescLabel_1.ForeColor = Color.Gray;
            ApplyConventionSettingDescLabel_1.Location = new Point(13, 28);
            ApplyConventionSettingDescLabel_1.Name = "ApplyConventionSettingDescLabel_1";
            ApplyConventionSettingDescLabel_1.Size = new Size(321, 11);
            ApplyConventionSettingDescLabel_1.TabIndex = 11;
            ApplyConventionSettingDescLabel_1.Text = "코드 컨벤션 규칙을 VS 포멧터에 적용되도록 하는 기능입니다. ";
            // 
            // UnityProjectPathLabel
            // 
            UnityProjectPathLabel.AutoSize = true;
            UnityProjectPathLabel.Location = new Point(13, 67);
            UnityProjectPathLabel.Name = "UnityProjectPathLabel";
            UnityProjectPathLabel.Size = new Size(195, 15);
            UnityProjectPathLabel.TabIndex = 10;
            UnityProjectPathLabel.Text = "컨벤션 적용할 Unity 프로젝트 경로";
            // 
            // UnityProjectDirPathTextButton
            // 
            UnityProjectDirPathTextButton.BorderStyle = BorderStyle.FixedSingle;
            UnityProjectDirPathTextButton.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UnityProjectDirPathTextButton.Location = new Point(212, 64);
            UnityProjectDirPathTextButton.Margin = new Padding(0);
            UnityProjectDirPathTextButton.Name = "UnityProjectDirPathTextButton";
            UnityProjectDirPathTextButton.ReadOnly = true;
            UnityProjectDirPathTextButton.Size = new Size(132, 20);
            UnityProjectDirPathTextButton.TabIndex = 5;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("굴림", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VersionLabel.ForeColor = Color.Teal;
            VersionLabel.Location = new Point(134, 68);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(104, 13);
            VersionLabel.TabIndex = 16;
            VersionLabel.Text = "Version X.X.X";
            // 
            // SnippetInstallGroupBox
            // 
            SnippetInstallGroupBox.BackgroundImageLayout = ImageLayout.None;
            SnippetInstallGroupBox.Controls.Add(SnippetGuideLinkLabel);
            SnippetInstallGroupBox.Controls.Add(SnippetWikiLinkLabel);
            SnippetInstallGroupBox.Controls.Add(OpenSnippetSavePathButton);
            SnippetInstallGroupBox.Controls.Add(UpdateSnippetButton);
            SnippetInstallGroupBox.Controls.Add(SnippetInstallDescLabel_1);
            SnippetInstallGroupBox.Controls.Add(SnippetSavePathLabel);
            SnippetInstallGroupBox.Controls.Add(SnippetSavePathTextBox);
            SnippetInstallGroupBox.Location = new Point(28, 721);
            SnippetInstallGroupBox.Margin = new Padding(3, 4, 3, 4);
            SnippetInstallGroupBox.Name = "SnippetInstallGroupBox";
            SnippetInstallGroupBox.Padding = new Padding(3, 4, 3, 4);
            SnippetInstallGroupBox.Size = new Size(442, 143);
            SnippetInstallGroupBox.TabIndex = 18;
            SnippetInstallGroupBox.TabStop = false;
            SnippetInstallGroupBox.Text = "C# 용 코드 스니펫 파일 다운로드 또는 업데이트";
            // 
            // SnippetGuideLinkLabel
            // 
            SnippetGuideLinkLabel.AutoSize = true;
            SnippetGuideLinkLabel.Location = new Point(133, 113);
            SnippetGuideLinkLabel.Name = "SnippetGuideLinkLabel";
            SnippetGuideLinkLabel.Size = new Size(127, 15);
            SnippetGuideLinkLabel.TabIndex = 16;
            SnippetGuideLinkLabel.TabStop = true;
            SnippetGuideLinkLabel.Text = "설치 후 사용하는 방법";
            SnippetGuideLinkLabel.LinkClicked += SnippetGuideLinkLabel_LinkClicked;
            // 
            // SnippetWikiLinkLabel
            // 
            SnippetWikiLinkLabel.AutoSize = true;
            SnippetWikiLinkLabel.Location = new Point(12, 113);
            SnippetWikiLinkLabel.Name = "SnippetWikiLinkLabel";
            SnippetWikiLinkLabel.Size = new Size(101, 15);
            SnippetWikiLinkLabel.TabIndex = 15;
            SnippetWikiLinkLabel.TabStop = true;
            SnippetWikiLinkLabel.Text = "코드 스니펫이란?";
            SnippetWikiLinkLabel.LinkClicked += SnippetWikiLinkLabel_LinkClicked;
            // 
            // SnippetInstallDescLabel_1
            // 
            SnippetInstallDescLabel_1.AutoSize = true;
            SnippetInstallDescLabel_1.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SnippetInstallDescLabel_1.ForeColor = Color.Gray;
            SnippetInstallDescLabel_1.Location = new Point(13, 26);
            SnippetInstallDescLabel_1.Name = "SnippetInstallDescLabel_1";
            SnippetInstallDescLabel_1.Size = new Size(259, 11);
            SnippetInstallDescLabel_1.TabIndex = 11;
            SnippetInstallDescLabel_1.Text = "자주 사용하는 코드 스니펫을 관리하는 기능입니다.";
            // 
            // SnippetSavePathLabel
            // 
            SnippetSavePathLabel.AutoSize = true;
            SnippetSavePathLabel.Location = new Point(13, 51);
            SnippetSavePathLabel.Name = "SnippetSavePathLabel";
            SnippetSavePathLabel.Size = new Size(123, 15);
            SnippetSavePathLabel.TabIndex = 10;
            SnippetSavePathLabel.Text = "스니펫을 저장할 경로";
            // 
            // SnippetSavePathTextBox
            // 
            SnippetSavePathTextBox.BorderStyle = BorderStyle.FixedSingle;
            SnippetSavePathTextBox.Font = new Font("굴림", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SnippetSavePathTextBox.Location = new Point(145, 48);
            SnippetSavePathTextBox.Margin = new Padding(0);
            SnippetSavePathTextBox.Name = "SnippetSavePathTextBox";
            SnippetSavePathTextBox.ReadOnly = true;
            SnippetSavePathTextBox.Size = new Size(199, 20);
            SnippetSavePathTextBox.TabIndex = 5;
            // 
            // HR_2
            // 
            HR_2.BorderStyle = BorderStyle.Fixed3D;
            HR_2.Location = new Point(28, 288);
            HR_2.Margin = new Padding(3, 4, 3, 4);
            HR_2.Name = "HR_2";
            HR_2.Size = new Size(442, 4);
            HR_2.TabIndex = 8;
            // 
            // HR_3
            // 
            HR_3.BorderStyle = BorderStyle.Fixed3D;
            HR_3.Location = new Point(28, 476);
            HR_3.Margin = new Padding(3, 4, 3, 4);
            HR_3.Name = "HR_3";
            HR_3.Size = new Size(442, 4);
            HR_3.TabIndex = 10;
            // 
            // HR_4
            // 
            HR_4.BorderStyle = BorderStyle.Fixed3D;
            HR_4.Location = new Point(28, 707);
            HR_4.Margin = new Padding(3, 4, 3, 4);
            HR_4.Name = "HR_4";
            HR_4.Size = new Size(442, 4);
            HR_4.TabIndex = 17;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Enabled = false;
            TeamNameLabel.Font = new Font("D2Coding", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(135, 88);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(196, 15);
            TeamNameLabel.TabIndex = 20;
            TeamNameLabel.Text = "Convention Rule : Team Name";
            TeamNameLabel.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenuButton, ToolMenuButton, HelpMenuButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(496, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuButton
            // 
            FileMenuButton.DropDownItems.AddRange(new ToolStripItem[] { ResourceDirOpenButton });
            FileMenuButton.Name = "FileMenuButton";
            FileMenuButton.Size = new Size(61, 20);
            FileMenuButton.Text = "파일 (&F)";
            // 
            // ResourceDirOpenButton
            // 
            ResourceDirOpenButton.Name = "ResourceDirOpenButton";
            ResourceDirOpenButton.Size = new Size(215, 22);
            ResourceDirOpenButton.Text = "리소스 파일 위치 열기 (&O)";
            ResourceDirOpenButton.Click += ResourceDirOpenButton_Click;
            // 
            // ToolMenuButton
            // 
            ToolMenuButton.DropDownItems.AddRange(new ToolStripItem[] { CustomToolButton });
            ToolMenuButton.Name = "ToolMenuButton";
            ToolMenuButton.Size = new Size(61, 20);
            ToolMenuButton.Text = "도구 (&T)";
            // 
            // CustomToolButton
            // 
            CustomToolButton.Name = "CustomToolButton";
            CustomToolButton.Size = new Size(180, 22);
            CustomToolButton.Text = "커스텀 도구 (&C)";
            CustomToolButton.Click += CustomToolButton_Click;
            // 
            // HelpMenuButton
            // 
            HelpMenuButton.DropDownItems.AddRange(new ToolStripItem[] { OpenGithubButton, OpenBlogButton });
            HelpMenuButton.Name = "HelpMenuButton";
            HelpMenuButton.Size = new Size(76, 20);
            HelpMenuButton.Text = "도움말 (&H)";
            // 
            // OpenGithubButton
            // 
            OpenGithubButton.Name = "OpenGithubButton";
            OpenGithubButton.Size = new Size(237, 22);
            OpenGithubButton.Text = "Convention Wizard에 대해 (&C)";
            OpenGithubButton.Click += OpenGithubButton_Click;
            // 
            // OpenBlogButton
            // 
            OpenBlogButton.Name = "OpenBlogButton";
            OpenBlogButton.Size = new Size(237, 22);
            OpenBlogButton.Text = "개발자 블로그 (&B)";
            OpenBlogButton.Click += OpenBlogButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(496, 875);
            Controls.Add(TeamNameLabel);
            Controls.Add(SnippetInstallGroupBox);
            Controls.Add(VersionLabel);
            Controls.Add(HR_4);
            Controls.Add(ApplyConventionSettingGroupBox);
            Controls.Add(HR_3);
            Controls.Add(CodeBaseInstallGroup);
            Controls.Add(HR_2);
            Controls.Add(VsixInstallGroup);
            Controls.Add(HR_1);
            Controls.Add(TitleSubLabel);
            Controls.Add(IconViewer);
            Controls.Add(TitleLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Convention Wizard For Unity";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)IconViewer).EndInit();
            VsixInstallGroup.ResumeLayout(false);
            CodeBaseInstallGroup.ResumeLayout(false);
            CodeBaseInstallGroup.PerformLayout();
            ApplyConventionSettingGroupBox.ResumeLayout(false);
            ApplyConventionSettingGroupBox.PerformLayout();
            SnippetInstallGroupBox.ResumeLayout(false);
            SnippetInstallGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion PRIVATE_METHOD

        #region PROTECTED_METHOD
        // ======================================================================================================================
        //  사용 중인 모든 리소스를 정리합니다.
        // ======================================================================================================================
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion PROTECTED_METHOD

        private LinkLabel CheckConventionLabel;
        private LinkLabel SnippetGuideLinkLabel;
        private LinkLabel SnippetWikiLinkLabel;
        private Label TeamNameLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuButton;
        private ToolStripMenuItem ResourceDirOpenButton;
        private ToolStripMenuItem ToolMenuButton;
        private ToolStripMenuItem CustomToolButton;
        private ToolStripMenuItem HelpMenuButton;
        private ToolStripMenuItem OpenGithubButton;
        private ToolStripMenuItem OpenBlogButton;
    }
}

