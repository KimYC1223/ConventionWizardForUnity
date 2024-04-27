namespace ConventionWizardForUnity
{
    partial class MainForm
    {
        #region MEMBER_FIELD
        // ======================================================================================================================
        //  WIN FORM UI OBJECT 모음
        // ======================================================================================================================
        #region UI_OBJECTS
        private System.Windows.Forms.Button InstallGuidelinesButtonVS2022;
        private System.Windows.Forms.Button InstallGuidelinesButtonVS2019;
        private System.Windows.Forms.Button InstallSonarLintButtonVS2022;
        private System.Windows.Forms.Button InstallCodeMaidButtonVS2022;
        private System.Windows.Forms.Button InstallSonarLintButtonVS2019;
        private System.Windows.Forms.Button InstallCodeMaidButtonVS2019;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox IconViewer;
        private System.Windows.Forms.Label TitleCopyrightLabel;
        private System.Windows.Forms.Label TitleSubLabel;
        private System.Windows.Forms.Panel HR_1;
        private System.Windows.Forms.GroupBox VsixInstallGroup;
        private System.Windows.Forms.GroupBox CodeBaseInstallGroup;
        private System.Windows.Forms.Label CodeBaseInstallDescLabel_2;
        private System.Windows.Forms.Label CodeBaseInstallDescLabel_1;
        private System.Windows.Forms.Label UnityEditorPathLabel;
        private System.Windows.Forms.TextBox UnityEditorDirPathTextButton;
        private System.Windows.Forms.GroupBox ApplyConventionSettingGroupBox;
        private System.Windows.Forms.Label ApplyConventionSettingDescLabel_2;
        private System.Windows.Forms.Label ApplyConventionSettingDescLabel_1;
        private System.Windows.Forms.Label UnityProjectPathLabel;
        private System.Windows.Forms.TextBox UnityProjectDirPathTextButton;
        private System.Windows.Forms.Label CodeBaseInstallGuideLabel;
        private System.Windows.Forms.Label ApplyConventionSettingGuideLabel_2;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ApplyConventionSettingGuideLabel_1;
        private System.Windows.Forms.GroupBox SnippetInstallGroupBox;
        private System.Windows.Forms.Label SnippetInstallDescLabel_1;
        private System.Windows.Forms.Label SnippetSavePathLabel;
        private System.Windows.Forms.TextBox SnippetSavePathTextBox;
        private System.Windows.Forms.Button ApplyConventionButton;
        private System.Windows.Forms.Panel HR_2;
        private System.Windows.Forms.Panel HR_3;
        private System.Windows.Forms.Panel HR_4;
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
            System.Windows.Forms.Button OpenUnityEditorDirButton;
            System.Windows.Forms.Button CodebaseReplaceButton;
            System.Windows.Forms.Button CodebaseRollbackButton;
            System.Windows.Forms.Button OpenUnityProjectDirButton;
            System.Windows.Forms.Button OpenSnippetSavePathButton;
            System.Windows.Forms.Button UpdateSnippetButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ApplyConventionButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.IconViewer = new System.Windows.Forms.PictureBox();
            this.TitleCopyrightLabel = new System.Windows.Forms.Label();
            this.TitleSubLabel = new System.Windows.Forms.Label();
            this.HR_1 = new System.Windows.Forms.Panel();
            this.VsixInstallGroup = new System.Windows.Forms.GroupBox();
            this.InstallGuidelinesButtonVS2022 = new System.Windows.Forms.Button();
            this.InstallGuidelinesButtonVS2019 = new System.Windows.Forms.Button();
            this.InstallSonarLintButtonVS2022 = new System.Windows.Forms.Button();
            this.InstallCodeMaidButtonVS2022 = new System.Windows.Forms.Button();
            this.InstallSonarLintButtonVS2019 = new System.Windows.Forms.Button();
            this.InstallCodeMaidButtonVS2019 = new System.Windows.Forms.Button();
            this.CodeBaseInstallGroup = new System.Windows.Forms.GroupBox();
            this.CodeBaseInstallGuideLabel = new System.Windows.Forms.Label();
            this.CodeBaseInstallDescLabel_2 = new System.Windows.Forms.Label();
            this.CodeBaseInstallDescLabel_1 = new System.Windows.Forms.Label();
            this.UnityEditorPathLabel = new System.Windows.Forms.Label();
            this.UnityEditorDirPathTextButton = new System.Windows.Forms.TextBox();
            this.ApplyConventionSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckConventionLabel = new System.Windows.Forms.LinkLabel();
            this.ApplyConventionSettingGuideLabel_1 = new System.Windows.Forms.Label();
            this.ApplyConventionSettingGuideLabel_2 = new System.Windows.Forms.Label();
            this.ApplyConventionSettingDescLabel_2 = new System.Windows.Forms.Label();
            this.ApplyConventionSettingDescLabel_1 = new System.Windows.Forms.Label();
            this.UnityProjectPathLabel = new System.Windows.Forms.Label();
            this.UnityProjectDirPathTextButton = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SnippetInstallGroupBox = new System.Windows.Forms.GroupBox();
            this.SnippetGuideLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SnippetWikiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SnippetInstallDescLabel_1 = new System.Windows.Forms.Label();
            this.SnippetSavePathLabel = new System.Windows.Forms.Label();
            this.SnippetSavePathTextBox = new System.Windows.Forms.TextBox();
            this.HR_2 = new System.Windows.Forms.Panel();
            this.HR_3 = new System.Windows.Forms.Panel();
            this.HR_4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ResourceDirOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenGithubButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBlogButton = new System.Windows.Forms.ToolStripMenuItem();
            OpenUnityEditorDirButton = new System.Windows.Forms.Button();
            CodebaseReplaceButton = new System.Windows.Forms.Button();
            CodebaseRollbackButton = new System.Windows.Forms.Button();
            OpenUnityProjectDirButton = new System.Windows.Forms.Button();
            OpenSnippetSavePathButton = new System.Windows.Forms.Button();
            UpdateSnippetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconViewer)).BeginInit();
            this.VsixInstallGroup.SuspendLayout();
            this.CodeBaseInstallGroup.SuspendLayout();
            this.ApplyConventionSettingGroupBox.SuspendLayout();
            this.SnippetInstallGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenUnityEditorDirButton
            // 
            OpenUnityEditorDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            OpenUnityEditorDirButton.Location = new System.Drawing.Point(350, 61);
            OpenUnityEditorDirButton.Name = "OpenUnityEditorDirButton";
            OpenUnityEditorDirButton.Size = new System.Drawing.Size(77, 22);
            OpenUnityEditorDirButton.TabIndex = 14;
            OpenUnityEditorDirButton.Text = "찾기";
            OpenUnityEditorDirButton.UseVisualStyleBackColor = true;
            OpenUnityEditorDirButton.Click += new System.EventHandler(this.OpenUnityEditorDirButton_Click);
            // 
            // CodebaseReplaceButton
            // 
            CodebaseReplaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            CodebaseReplaceButton.Location = new System.Drawing.Point(230, 92);
            CodebaseReplaceButton.Name = "CodebaseReplaceButton";
            CodebaseReplaceButton.Size = new System.Drawing.Size(197, 26);
            CodebaseReplaceButton.TabIndex = 13;
            CodebaseReplaceButton.Text = "코드베이스 변경";
            CodebaseReplaceButton.UseVisualStyleBackColor = true;
            CodebaseReplaceButton.Click += new System.EventHandler(this.CodebaseReplaceButton_Click);
            // 
            // CodebaseRollbackButton
            // 
            CodebaseRollbackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            CodebaseRollbackButton.Location = new System.Drawing.Point(15, 92);
            CodebaseRollbackButton.Name = "CodebaseRollbackButton";
            CodebaseRollbackButton.Size = new System.Drawing.Size(197, 26);
            CodebaseRollbackButton.TabIndex = 4;
            CodebaseRollbackButton.Text = "원복시키기";
            CodebaseRollbackButton.UseVisualStyleBackColor = true;
            CodebaseRollbackButton.Click += new System.EventHandler(this.CodebaseRollbackButton_Click);
            // 
            // OpenUnityProjectDirButton
            // 
            OpenUnityProjectDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            OpenUnityProjectDirButton.Location = new System.Drawing.Point(350, 59);
            OpenUnityProjectDirButton.Name = "OpenUnityProjectDirButton";
            OpenUnityProjectDirButton.Size = new System.Drawing.Size(77, 22);
            OpenUnityProjectDirButton.TabIndex = 14;
            OpenUnityProjectDirButton.Text = "찾기";
            OpenUnityProjectDirButton.UseVisualStyleBackColor = true;
            OpenUnityProjectDirButton.Click += new System.EventHandler(this.OpenUnityProjectDirButton_Click);
            // 
            // OpenSnippetSavePathButton
            // 
            OpenSnippetSavePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            OpenSnippetSavePathButton.Location = new System.Drawing.Point(350, 43);
            OpenSnippetSavePathButton.Name = "OpenSnippetSavePathButton";
            OpenSnippetSavePathButton.Size = new System.Drawing.Size(77, 22);
            OpenSnippetSavePathButton.TabIndex = 14;
            OpenSnippetSavePathButton.Text = "찾기";
            OpenSnippetSavePathButton.UseVisualStyleBackColor = true;
            OpenSnippetSavePathButton.Click += new System.EventHandler(this.OpenSnippetSavePathButton_Click);
            // 
            // UpdateSnippetButton
            // 
            UpdateSnippetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            UpdateSnippetButton.Location = new System.Drawing.Point(16, 70);
            UpdateSnippetButton.Name = "UpdateSnippetButton";
            UpdateSnippetButton.Size = new System.Drawing.Size(412, 26);
            UpdateSnippetButton.TabIndex = 13;
            UpdateSnippetButton.Text = "C# 코드 스니펫 다운로드 및 업데이트";
            UpdateSnippetButton.UseVisualStyleBackColor = true;
            UpdateSnippetButton.Click += new System.EventHandler(this.UpdateSnippetButton_Click);
            // 
            // ApplyConventionButton
            // 
            this.ApplyConventionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyConventionButton.Location = new System.Drawing.Point(15, 91);
            this.ApplyConventionButton.Name = "ApplyConventionButton";
            this.ApplyConventionButton.Size = new System.Drawing.Size(412, 26);
            this.ApplyConventionButton.TabIndex = 13;
            this.ApplyConventionButton.Text = "Unity 프로젝트에 코드 컨벤션 적용";
            this.ApplyConventionButton.UseVisualStyleBackColor = true;
            this.ApplyConventionButton.Click += new System.EventHandler(this.ApplyConventionButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("D2Coding", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.Location = new System.Drawing.Point(122, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(280, 24);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Convention Wizard For Unity";
            // 
            // IconViewer
            // 
            this.IconViewer.Image = global::ConventionWizardForUnity.Properties.Resources.Icon;
            this.IconViewer.Location = new System.Drawing.Point(19, 24);
            this.IconViewer.Name = "IconViewer";
            this.IconViewer.Size = new System.Drawing.Size(100, 100);
            this.IconViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconViewer.TabIndex = 1;
            this.IconViewer.TabStop = false;
            // 
            // TitleCopyrightLabel
            // 
            this.TitleCopyrightLabel.AutoSize = true;
            this.TitleCopyrightLabel.Enabled = false;
            this.TitleCopyrightLabel.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleCopyrightLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TitleCopyrightLabel.Location = new System.Drawing.Point(135, 81);
            this.TitleCopyrightLabel.Name = "TitleCopyrightLabel";
            this.TitleCopyrightLabel.Size = new System.Drawing.Size(187, 14);
            this.TitleCopyrightLabel.TabIndex = 2;
            this.TitleCopyrightLabel.Text = "Developed by KimYC1223 2024.04";
            // 
            // TitleSubLabel
            // 
            this.TitleSubLabel.AutoSize = true;
            this.TitleSubLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleSubLabel.Location = new System.Drawing.Point(27, 129);
            this.TitleSubLabel.Name = "TitleSubLabel";
            this.TitleSubLabel.Size = new System.Drawing.Size(336, 12);
            this.TitleSubLabel.TabIndex = 4;
            this.TitleSubLabel.Text = "Unity C# 개발자용 코드 컨벤션 유지를 위한 환경 설정 도우미";
            // 
            // HR_1
            // 
            this.HR_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HR_1.Location = new System.Drawing.Point(29, 156);
            this.HR_1.Name = "HR_1";
            this.HR_1.Size = new System.Drawing.Size(442, 4);
            this.HR_1.TabIndex = 6;
            // 
            // VsixInstallGroup
            // 
            this.VsixInstallGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.VsixInstallGroup.Controls.Add(this.InstallGuidelinesButtonVS2022);
            this.VsixInstallGroup.Controls.Add(this.InstallGuidelinesButtonVS2019);
            this.VsixInstallGroup.Controls.Add(this.InstallSonarLintButtonVS2022);
            this.VsixInstallGroup.Controls.Add(this.InstallCodeMaidButtonVS2022);
            this.VsixInstallGroup.Controls.Add(this.InstallSonarLintButtonVS2019);
            this.VsixInstallGroup.Controls.Add(this.InstallCodeMaidButtonVS2019);
            this.VsixInstallGroup.Location = new System.Drawing.Point(29, 172);
            this.VsixInstallGroup.Name = "VsixInstallGroup";
            this.VsixInstallGroup.Size = new System.Drawing.Size(442, 128);
            this.VsixInstallGroup.TabIndex = 7;
            this.VsixInstallGroup.TabStop = false;
            this.VsixInstallGroup.Text = "Visual Studio용 VSIX 설치";
            // 
            // InstallGuidelinesButtonVS2022
            // 
            this.InstallGuidelinesButtonVS2022.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallGuidelinesButtonVS2022.Location = new System.Drawing.Point(227, 88);
            this.InstallGuidelinesButtonVS2022.Name = "InstallGuidelinesButtonVS2022";
            this.InstallGuidelinesButtonVS2022.Size = new System.Drawing.Size(200, 26);
            this.InstallGuidelinesButtonVS2022.TabIndex = 8;
            this.InstallGuidelinesButtonVS2022.Text = "Guidelines 설치 (VS2022)";
            this.InstallGuidelinesButtonVS2022.UseVisualStyleBackColor = true;
            this.InstallGuidelinesButtonVS2022.Click += new System.EventHandler(this.InstallGuidelinesButtonVS2022_Click);
            // 
            // InstallGuidelinesButtonVS2019
            // 
            this.InstallGuidelinesButtonVS2019.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallGuidelinesButtonVS2019.Location = new System.Drawing.Point(15, 88);
            this.InstallGuidelinesButtonVS2019.Name = "InstallGuidelinesButtonVS2019";
            this.InstallGuidelinesButtonVS2019.Size = new System.Drawing.Size(200, 26);
            this.InstallGuidelinesButtonVS2019.TabIndex = 7;
            this.InstallGuidelinesButtonVS2019.Text = "Guidelines 설치 (VS2019)";
            this.InstallGuidelinesButtonVS2019.UseVisualStyleBackColor = true;
            this.InstallGuidelinesButtonVS2019.Click += new System.EventHandler(this.InstallGuidelinesButtonVS2019_Click);
            // 
            // InstallSonarLintButtonVS2022
            // 
            this.InstallSonarLintButtonVS2022.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallSonarLintButtonVS2022.Location = new System.Drawing.Point(227, 56);
            this.InstallSonarLintButtonVS2022.Name = "InstallSonarLintButtonVS2022";
            this.InstallSonarLintButtonVS2022.Size = new System.Drawing.Size(200, 26);
            this.InstallSonarLintButtonVS2022.TabIndex = 6;
            this.InstallSonarLintButtonVS2022.Text = "SonarLint 설치 (VS2022)";
            this.InstallSonarLintButtonVS2022.UseVisualStyleBackColor = true;
            this.InstallSonarLintButtonVS2022.Click += new System.EventHandler(this.InstallSonarLintButtonVS2022_Click);
            // 
            // InstallCodeMaidButtonVS2022
            // 
            this.InstallCodeMaidButtonVS2022.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallCodeMaidButtonVS2022.Location = new System.Drawing.Point(227, 24);
            this.InstallCodeMaidButtonVS2022.Name = "InstallCodeMaidButtonVS2022";
            this.InstallCodeMaidButtonVS2022.Size = new System.Drawing.Size(200, 26);
            this.InstallCodeMaidButtonVS2022.TabIndex = 5;
            this.InstallCodeMaidButtonVS2022.Text = "CodeMaid 설치 (VS2022)";
            this.InstallCodeMaidButtonVS2022.UseVisualStyleBackColor = true;
            this.InstallCodeMaidButtonVS2022.Click += new System.EventHandler(this.InstallCodeMaidButtonVS2022_Click);
            // 
            // InstallSonarLintButtonVS2019
            // 
            this.InstallSonarLintButtonVS2019.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallSonarLintButtonVS2019.Location = new System.Drawing.Point(15, 56);
            this.InstallSonarLintButtonVS2019.Name = "InstallSonarLintButtonVS2019";
            this.InstallSonarLintButtonVS2019.Size = new System.Drawing.Size(200, 26);
            this.InstallSonarLintButtonVS2019.TabIndex = 4;
            this.InstallSonarLintButtonVS2019.Text = "SonarLint 설치 (VS2019)";
            this.InstallSonarLintButtonVS2019.UseVisualStyleBackColor = true;
            this.InstallSonarLintButtonVS2019.Click += new System.EventHandler(this.InstallSonarLintButtonVS2019_Click);
            // 
            // InstallCodeMaidButtonVS2019
            // 
            this.InstallCodeMaidButtonVS2019.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallCodeMaidButtonVS2019.Location = new System.Drawing.Point(15, 24);
            this.InstallCodeMaidButtonVS2019.Name = "InstallCodeMaidButtonVS2019";
            this.InstallCodeMaidButtonVS2019.Size = new System.Drawing.Size(200, 26);
            this.InstallCodeMaidButtonVS2019.TabIndex = 3;
            this.InstallCodeMaidButtonVS2019.Text = "CodeMaid 설치 (VS2019)";
            this.InstallCodeMaidButtonVS2019.UseVisualStyleBackColor = true;
            this.InstallCodeMaidButtonVS2019.Click += new System.EventHandler(this.InstallCodeMaidButtonVS2019_Click);
            // 
            // CodeBaseInstallGroup
            // 
            this.CodeBaseInstallGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CodeBaseInstallGroup.Controls.Add(this.CodeBaseInstallGuideLabel);
            this.CodeBaseInstallGroup.Controls.Add(OpenUnityEditorDirButton);
            this.CodeBaseInstallGroup.Controls.Add(CodebaseReplaceButton);
            this.CodeBaseInstallGroup.Controls.Add(this.CodeBaseInstallDescLabel_2);
            this.CodeBaseInstallGroup.Controls.Add(this.CodeBaseInstallDescLabel_1);
            this.CodeBaseInstallGroup.Controls.Add(this.UnityEditorPathLabel);
            this.CodeBaseInstallGroup.Controls.Add(this.UnityEditorDirPathTextButton);
            this.CodeBaseInstallGroup.Controls.Add(CodebaseRollbackButton);
            this.CodeBaseInstallGroup.Location = new System.Drawing.Point(29, 328);
            this.CodeBaseInstallGroup.Name = "CodeBaseInstallGroup";
            this.CodeBaseInstallGroup.Size = new System.Drawing.Size(442, 153);
            this.CodeBaseInstallGroup.TabIndex = 9;
            this.CodeBaseInstallGroup.TabStop = false;
            this.CodeBaseInstallGroup.Text = "Unity 코드 베이스 수정하기";
            // 
            // CodeBaseInstallGuideLabel
            // 
            this.CodeBaseInstallGuideLabel.AutoSize = true;
            this.CodeBaseInstallGuideLabel.ForeColor = System.Drawing.Color.Teal;
            this.CodeBaseInstallGuideLabel.Location = new System.Drawing.Point(16, 127);
            this.CodeBaseInstallGuideLabel.Name = "CodeBaseInstallGuideLabel";
            this.CodeBaseInstallGuideLabel.Size = new System.Drawing.Size(247, 12);
            this.CodeBaseInstallGuideLabel.TabIndex = 15;
            this.CodeBaseInstallGuideLabel.Text = "기본 값은 C:\\Program Files\\Unity 입니다.";
            // 
            // CodeBaseInstallDescLabel_2
            // 
            this.CodeBaseInstallDescLabel_2.AutoSize = true;
            this.CodeBaseInstallDescLabel_2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CodeBaseInstallDescLabel_2.ForeColor = System.Drawing.Color.Gray;
            this.CodeBaseInstallDescLabel_2.Location = new System.Drawing.Point(13, 41);
            this.CodeBaseInstallDescLabel_2.Name = "CodeBaseInstallDescLabel_2";
            this.CodeBaseInstallDescLabel_2.Size = new System.Drawing.Size(367, 11);
            this.CodeBaseInstallDescLabel_2.TabIndex = 12;
            this.CodeBaseInstallDescLabel_2.Text = "되도록 하는 기능입니다. (프로젝트에 상관없이 에디터 버전에 전체 적용)";
            // 
            // CodeBaseInstallDescLabel_1
            // 
            this.CodeBaseInstallDescLabel_1.AutoSize = true;
            this.CodeBaseInstallDescLabel_1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CodeBaseInstallDescLabel_1.ForeColor = System.Drawing.Color.Gray;
            this.CodeBaseInstallDescLabel_1.Location = new System.Drawing.Point(13, 22);
            this.CodeBaseInstallDescLabel_1.Name = "CodeBaseInstallDescLabel_1";
            this.CodeBaseInstallDescLabel_1.Size = new System.Drawing.Size(377, 11);
            this.CodeBaseInstallDescLabel_1.TabIndex = 11;
            this.CodeBaseInstallDescLabel_1.Text = "Unity Editor에서, 새로운 C# 파일을 만들 때 자동으로 코드 스타일이 적용";
            // 
            // UnityEditorPathLabel
            // 
            this.UnityEditorPathLabel.AutoSize = true;
            this.UnityEditorPathLabel.Location = new System.Drawing.Point(13, 67);
            this.UnityEditorPathLabel.Name = "UnityEditorPathLabel";
            this.UnityEditorPathLabel.Size = new System.Drawing.Size(125, 12);
            this.UnityEditorPathLabel.TabIndex = 10;
            this.UnityEditorPathLabel.Text = "Unity Editor 설치 경로";
            // 
            // UnityEditorDirPathTextButton
            // 
            this.UnityEditorDirPathTextButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnityEditorDirPathTextButton.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnityEditorDirPathTextButton.Location = new System.Drawing.Point(147, 61);
            this.UnityEditorDirPathTextButton.Margin = new System.Windows.Forms.Padding(0);
            this.UnityEditorDirPathTextButton.Name = "UnityEditorDirPathTextButton";
            this.UnityEditorDirPathTextButton.ReadOnly = true;
            this.UnityEditorDirPathTextButton.Size = new System.Drawing.Size(197, 20);
            this.UnityEditorDirPathTextButton.TabIndex = 5;
            this.UnityEditorDirPathTextButton.Text = "C:\\Program Files\\Unity";
            // 
            // ApplyConventionSettingGroupBox
            // 
            this.ApplyConventionSettingGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplyConventionSettingGroupBox.Controls.Add(this.CheckConventionLabel);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.ApplyConventionSettingGuideLabel_1);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.ApplyConventionSettingGuideLabel_2);
            this.ApplyConventionSettingGroupBox.Controls.Add(OpenUnityProjectDirButton);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.ApplyConventionButton);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.ApplyConventionSettingDescLabel_2);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.ApplyConventionSettingDescLabel_1);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.UnityProjectPathLabel);
            this.ApplyConventionSettingGroupBox.Controls.Add(this.UnityProjectDirPathTextButton);
            this.ApplyConventionSettingGroupBox.Location = new System.Drawing.Point(29, 509);
            this.ApplyConventionSettingGroupBox.Name = "ApplyConventionSettingGroupBox";
            this.ApplyConventionSettingGroupBox.Size = new System.Drawing.Size(442, 192);
            this.ApplyConventionSettingGroupBox.TabIndex = 15;
            this.ApplyConventionSettingGroupBox.TabStop = false;
            this.ApplyConventionSettingGroupBox.Text = "Unity 코드 컨벤션 설정 파일 적용";
            // 
            // CheckConventionLabel
            // 
            this.CheckConventionLabel.AutoSize = true;
            this.CheckConventionLabel.Location = new System.Drawing.Point(15, 170);
            this.CheckConventionLabel.Name = "CheckConventionLabel";
            this.CheckConventionLabel.Size = new System.Drawing.Size(145, 12);
            this.CheckConventionLabel.TabIndex = 18;
            this.CheckConventionLabel.TabStop = true;
            this.CheckConventionLabel.Text = "코드 컨벤션 확인하러가기";
            this.CheckConventionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckConventionLabel_LinkClicked);
            // 
            // ApplyConventionSettingGuideLabel_1
            // 
            this.ApplyConventionSettingGuideLabel_1.AutoSize = true;
            this.ApplyConventionSettingGuideLabel_1.ForeColor = System.Drawing.Color.Teal;
            this.ApplyConventionSettingGuideLabel_1.Location = new System.Drawing.Point(16, 147);
            this.ApplyConventionSettingGuideLabel_1.Name = "ApplyConventionSettingGuideLabel_1";
            this.ApplyConventionSettingGuideLabel_1.Size = new System.Drawing.Size(359, 12);
            this.ApplyConventionSettingGuideLabel_1.TabIndex = 16;
            this.ApplyConventionSettingGuideLabel_1.Text = "만들거나, 업데이트를 적용하고나서, 최초 1회만 적용하면 됩니다.";
            // 
            // ApplyConventionSettingGuideLabel_2
            // 
            this.ApplyConventionSettingGuideLabel_2.AutoSize = true;
            this.ApplyConventionSettingGuideLabel_2.ForeColor = System.Drawing.Color.Teal;
            this.ApplyConventionSettingGuideLabel_2.Location = new System.Drawing.Point(16, 127);
            this.ApplyConventionSettingGuideLabel_2.Name = "ApplyConventionSettingGuideLabel_2";
            this.ApplyConventionSettingGuideLabel_2.Size = new System.Drawing.Size(398, 12);
            this.ApplyConventionSettingGuideLabel_2.TabIndex = 15;
            this.ApplyConventionSettingGuideLabel_2.Text = "프로젝트의 sln 파일이 있는 위치를 설정하시면 됩니다. 신규 프로젝트를 ";
            // 
            // ApplyConventionSettingDescLabel_2
            // 
            this.ApplyConventionSettingDescLabel_2.AutoSize = true;
            this.ApplyConventionSettingDescLabel_2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApplyConventionSettingDescLabel_2.ForeColor = System.Drawing.Color.Gray;
            this.ApplyConventionSettingDescLabel_2.Location = new System.Drawing.Point(13, 41);
            this.ApplyConventionSettingDescLabel_2.Name = "ApplyConventionSettingDescLabel_2";
            this.ApplyConventionSettingDescLabel_2.Size = new System.Drawing.Size(216, 11);
            this.ApplyConventionSettingDescLabel_2.TabIndex = 12;
            this.ApplyConventionSettingDescLabel_2.Text = "(에디터 버전에 상관없이 프로젝트에 적용)";
            // 
            // ApplyConventionSettingDescLabel_1
            // 
            this.ApplyConventionSettingDescLabel_1.AutoSize = true;
            this.ApplyConventionSettingDescLabel_1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApplyConventionSettingDescLabel_1.ForeColor = System.Drawing.Color.Gray;
            this.ApplyConventionSettingDescLabel_1.Location = new System.Drawing.Point(13, 22);
            this.ApplyConventionSettingDescLabel_1.Name = "ApplyConventionSettingDescLabel_1";
            this.ApplyConventionSettingDescLabel_1.Size = new System.Drawing.Size(321, 11);
            this.ApplyConventionSettingDescLabel_1.TabIndex = 11;
            this.ApplyConventionSettingDescLabel_1.Text = "코드 컨벤션 규칙을 VS 포멧터에 적용되도록 하는 기능입니다. ";
            // 
            // UnityProjectPathLabel
            // 
            this.UnityProjectPathLabel.AutoSize = true;
            this.UnityProjectPathLabel.Location = new System.Drawing.Point(13, 65);
            this.UnityProjectPathLabel.Name = "UnityProjectPathLabel";
            this.UnityProjectPathLabel.Size = new System.Drawing.Size(193, 12);
            this.UnityProjectPathLabel.TabIndex = 10;
            this.UnityProjectPathLabel.Text = "컨벤션 적용할 Unity 프로젝트 경로";
            // 
            // UnityProjectDirPathTextButton
            // 
            this.UnityProjectDirPathTextButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnityProjectDirPathTextButton.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnityProjectDirPathTextButton.Location = new System.Drawing.Point(212, 59);
            this.UnityProjectDirPathTextButton.Margin = new System.Windows.Forms.Padding(0);
            this.UnityProjectDirPathTextButton.Name = "UnityProjectDirPathTextButton";
            this.UnityProjectDirPathTextButton.ReadOnly = true;
            this.UnityProjectDirPathTextButton.Size = new System.Drawing.Size(132, 20);
            this.UnityProjectDirPathTextButton.TabIndex = 5;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VersionLabel.ForeColor = System.Drawing.Color.Teal;
            this.VersionLabel.Location = new System.Drawing.Point(134, 62);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(104, 13);
            this.VersionLabel.TabIndex = 16;
            this.VersionLabel.Text = "Version X.X.X";
            // 
            // SnippetInstallGroupBox
            // 
            this.SnippetInstallGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SnippetInstallGroupBox.Controls.Add(this.SnippetGuideLinkLabel);
            this.SnippetInstallGroupBox.Controls.Add(this.SnippetWikiLinkLabel);
            this.SnippetInstallGroupBox.Controls.Add(OpenSnippetSavePathButton);
            this.SnippetInstallGroupBox.Controls.Add(UpdateSnippetButton);
            this.SnippetInstallGroupBox.Controls.Add(this.SnippetInstallDescLabel_1);
            this.SnippetInstallGroupBox.Controls.Add(this.SnippetSavePathLabel);
            this.SnippetInstallGroupBox.Controls.Add(this.SnippetSavePathTextBox);
            this.SnippetInstallGroupBox.Location = new System.Drawing.Point(29, 729);
            this.SnippetInstallGroupBox.Name = "SnippetInstallGroupBox";
            this.SnippetInstallGroupBox.Size = new System.Drawing.Size(442, 136);
            this.SnippetInstallGroupBox.TabIndex = 18;
            this.SnippetInstallGroupBox.TabStop = false;
            this.SnippetInstallGroupBox.Text = "C# 용 코드 스니펫 파일 다운로드 또는 업데이트";
            // 
            // SnippetGuideLinkLabel
            // 
            this.SnippetGuideLinkLabel.AutoSize = true;
            this.SnippetGuideLinkLabel.Location = new System.Drawing.Point(133, 108);
            this.SnippetGuideLinkLabel.Name = "SnippetGuideLinkLabel";
            this.SnippetGuideLinkLabel.Size = new System.Drawing.Size(125, 12);
            this.SnippetGuideLinkLabel.TabIndex = 16;
            this.SnippetGuideLinkLabel.TabStop = true;
            this.SnippetGuideLinkLabel.Text = "설치 후 사용하는 방법";
            this.SnippetGuideLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SnippetGuideLinkLabel_LinkClicked);
            // 
            // SnippetWikiLinkLabel
            // 
            this.SnippetWikiLinkLabel.AutoSize = true;
            this.SnippetWikiLinkLabel.Location = new System.Drawing.Point(12, 108);
            this.SnippetWikiLinkLabel.Name = "SnippetWikiLinkLabel";
            this.SnippetWikiLinkLabel.Size = new System.Drawing.Size(99, 12);
            this.SnippetWikiLinkLabel.TabIndex = 15;
            this.SnippetWikiLinkLabel.TabStop = true;
            this.SnippetWikiLinkLabel.Text = "코드 스니펫이란?";
            this.SnippetWikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SnippetWikiLinkLabel_LinkClicked);
            // 
            // SnippetInstallDescLabel_1
            // 
            this.SnippetInstallDescLabel_1.AutoSize = true;
            this.SnippetInstallDescLabel_1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SnippetInstallDescLabel_1.ForeColor = System.Drawing.Color.Gray;
            this.SnippetInstallDescLabel_1.Location = new System.Drawing.Point(13, 22);
            this.SnippetInstallDescLabel_1.Name = "SnippetInstallDescLabel_1";
            this.SnippetInstallDescLabel_1.Size = new System.Drawing.Size(259, 11);
            this.SnippetInstallDescLabel_1.TabIndex = 11;
            this.SnippetInstallDescLabel_1.Text = "자주 사용하는 코드 스니펫을 관리하는 기능입니다.";
            // 
            // SnippetSavePathLabel
            // 
            this.SnippetSavePathLabel.AutoSize = true;
            this.SnippetSavePathLabel.Location = new System.Drawing.Point(13, 48);
            this.SnippetSavePathLabel.Name = "SnippetSavePathLabel";
            this.SnippetSavePathLabel.Size = new System.Drawing.Size(121, 12);
            this.SnippetSavePathLabel.TabIndex = 10;
            this.SnippetSavePathLabel.Text = "스니펫을 저장할 경로";
            // 
            // SnippetSavePathTextBox
            // 
            this.SnippetSavePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SnippetSavePathTextBox.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SnippetSavePathTextBox.Location = new System.Drawing.Point(145, 43);
            this.SnippetSavePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SnippetSavePathTextBox.Name = "SnippetSavePathTextBox";
            this.SnippetSavePathTextBox.ReadOnly = true;
            this.SnippetSavePathTextBox.Size = new System.Drawing.Size(199, 20);
            this.SnippetSavePathTextBox.TabIndex = 5;
            // 
            // HR_2
            // 
            this.HR_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HR_2.Location = new System.Drawing.Point(29, 312);
            this.HR_2.Name = "HR_2";
            this.HR_2.Size = new System.Drawing.Size(442, 4);
            this.HR_2.TabIndex = 8;
            // 
            // HR_3
            // 
            this.HR_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HR_3.Location = new System.Drawing.Point(29, 493);
            this.HR_3.Name = "HR_3";
            this.HR_3.Size = new System.Drawing.Size(442, 4);
            this.HR_3.TabIndex = 10;
            // 
            // HR_4
            // 
            this.HR_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HR_4.Location = new System.Drawing.Point(29, 713);
            this.HR_4.Name = "HR_4";
            this.HR_4.Size = new System.Drawing.Size(442, 4);
            this.HR_4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(135, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Convention Rule : Team Name";
            this.label1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuButton,
            this.ToolMenuButton,
            this.HelpMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuButton
            // 
            this.FileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResourceDirOpenButton});
            this.FileMenuButton.Name = "FileMenuButton";
            this.FileMenuButton.Size = new System.Drawing.Size(61, 20);
            this.FileMenuButton.Text = "파일 (&F)";
            // 
            // ResourceDirOpenButton
            // 
            this.ResourceDirOpenButton.Name = "ResourceDirOpenButton";
            this.ResourceDirOpenButton.Size = new System.Drawing.Size(215, 22);
            this.ResourceDirOpenButton.Text = "리소스 파일 위치 열기 (&O)";
            this.ResourceDirOpenButton.Click += new System.EventHandler(this.ResourceDirOpenButton_Click);
            // 
            // ToolMenuButton
            // 
            this.ToolMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomToolButton});
            this.ToolMenuButton.Name = "ToolMenuButton";
            this.ToolMenuButton.Size = new System.Drawing.Size(61, 20);
            this.ToolMenuButton.Text = "도구 (&T)";
            // 
            // CustomToolButton
            // 
            this.CustomToolButton.Name = "CustomToolButton";
            this.CustomToolButton.Size = new System.Drawing.Size(180, 22);
            this.CustomToolButton.Text = "커스텀 도구 (&C)";
            this.CustomToolButton.Click += new System.EventHandler(this.CustomToolButton_Click);
            // 
            // HelpMenuButton
            // 
            this.HelpMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenGithubButton,
            this.OpenBlogButton});
            this.HelpMenuButton.Name = "HelpMenuButton";
            this.HelpMenuButton.Size = new System.Drawing.Size(76, 20);
            this.HelpMenuButton.Text = "도움말 (&H)";
            // 
            // OpenGithubButton
            // 
            this.OpenGithubButton.Name = "OpenGithubButton";
            this.OpenGithubButton.Size = new System.Drawing.Size(237, 22);
            this.OpenGithubButton.Text = "Convention Wizard에 대해 (&C)";
            this.OpenGithubButton.Click += new System.EventHandler(this.OpenGithubButton_Click);
            // 
            // OpenBlogButton
            // 
            this.OpenBlogButton.Name = "OpenBlogButton";
            this.OpenBlogButton.Size = new System.Drawing.Size(237, 22);
            this.OpenBlogButton.Text = "개발자 블로그 (&B)";
            this.OpenBlogButton.Click += new System.EventHandler(this.OpenBlogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(496, 872);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SnippetInstallGroupBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.HR_4);
            this.Controls.Add(this.ApplyConventionSettingGroupBox);
            this.Controls.Add(this.HR_3);
            this.Controls.Add(this.CodeBaseInstallGroup);
            this.Controls.Add(this.HR_2);
            this.Controls.Add(this.VsixInstallGroup);
            this.Controls.Add(this.HR_1);
            this.Controls.Add(this.TitleSubLabel);
            this.Controls.Add(this.TitleCopyrightLabel);
            this.Controls.Add(this.IconViewer);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Convention Wizard For Unity";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconViewer)).EndInit();
            this.VsixInstallGroup.ResumeLayout(false);
            this.CodeBaseInstallGroup.ResumeLayout(false);
            this.CodeBaseInstallGroup.PerformLayout();
            this.ApplyConventionSettingGroupBox.ResumeLayout(false);
            this.ApplyConventionSettingGroupBox.PerformLayout();
            this.SnippetInstallGroupBox.ResumeLayout(false);
            this.SnippetInstallGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.LinkLabel CheckConventionLabel;
        private System.Windows.Forms.LinkLabel SnippetGuideLinkLabel;
        private System.Windows.Forms.LinkLabel SnippetWikiLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ResourceDirOpenButton;
        private System.Windows.Forms.ToolStripMenuItem ToolMenuButton;
        private System.Windows.Forms.ToolStripMenuItem CustomToolButton;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuButton;
        private System.Windows.Forms.ToolStripMenuItem OpenGithubButton;
        private System.Windows.Forms.ToolStripMenuItem OpenBlogButton;
    }
}

