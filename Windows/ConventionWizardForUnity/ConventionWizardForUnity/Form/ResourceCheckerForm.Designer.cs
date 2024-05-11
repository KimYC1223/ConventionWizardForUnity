namespace ConventionWizardForUnity
{
    public partial class InitializingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializingForm));
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImage
            // 
            this.LogoImage.BackgroundImage = global::ConventionWizardForUnity.Properties.Resources.Icon;
            this.LogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoImage.Location = new System.Drawing.Point(7, 10);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(140, 140);
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(156, 87);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(433, 10);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("D2Coding", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.Location = new System.Drawing.Point(145, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(336, 28);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Convention Wizard For Unity";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VersionLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.VersionLabel.Location = new System.Drawing.Point(488, 36);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(0, 12);
            this.VersionLabel.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DescriptionLabel.Location = new System.Drawing.Point(154, 60);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(310, 12);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Unity / C# 용 코드 컨벤션 유지를 위한 환경 설정 도우미";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.StatusLabel.Location = new System.Drawing.Point(154, 114);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(113, 12);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Download : filepath";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(512, 109);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 23);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "확인";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.OnNextButtonClicked);
            // 
            // ResourceChecker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 150);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.LogoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResourceChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResourceChecker";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImage;
        public System.Windows.Forms.ProgressBar ProgressBar;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.Button NextButton;
    }
}