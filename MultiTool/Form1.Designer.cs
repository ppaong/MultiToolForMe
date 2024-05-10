namespace MultiTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mp3Button = new System.Windows.Forms.RadioButton();
            this.mp4Button = new System.Windows.Forms.RadioButton();
            this.YouTubeProgressBar = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.YouTubePercentage = new System.Windows.Forms.Label();
            this.videoNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.MenuBarButton4 = new System.Windows.Forms.Button();
            this.MenuBarButton3 = new System.Windows.Forms.Button();
            this.MenuBarButton2 = new System.Windows.Forms.Button();
            this.MenuBarButton1 = new System.Windows.Forms.Button();
            this.MenuBarCheckBox = new System.Windows.Forms.CheckBox();
            this.MenuBarTimer = new System.Windows.Forms.Timer(this.components);
            this.YouTubeThumbnail = new System.Windows.Forms.PictureBox();
            this.YouTubeInfoLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.urlListBox = new System.Windows.Forms.ListBox();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(67, 53);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(240, 21);
            this.urlTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "YouTube Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL =>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path =>";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(67, 325);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(240, 21);
            this.pathTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "붙여넣기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "파일 탐색기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mp3Button
            // 
            this.mp3Button.AutoSize = true;
            this.mp3Button.Location = new System.Drawing.Point(68, 379);
            this.mp3Button.Name = "mp3Button";
            this.mp3Button.Size = new System.Drawing.Size(48, 16);
            this.mp3Button.TabIndex = 8;
            this.mp3Button.TabStop = true;
            this.mp3Button.Text = "MP3";
            this.mp3Button.UseVisualStyleBackColor = true;
            // 
            // mp4Button
            // 
            this.mp4Button.AutoSize = true;
            this.mp4Button.Location = new System.Drawing.Point(164, 379);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(48, 16);
            this.mp4Button.TabIndex = 9;
            this.mp4Button.TabStop = true;
            this.mp4Button.Text = "MP4";
            this.mp4Button.UseVisualStyleBackColor = true;
            // 
            // YouTubeProgressBar
            // 
            this.YouTubeProgressBar.Location = new System.Drawing.Point(67, 399);
            this.YouTubeProgressBar.Name = "YouTubeProgressBar";
            this.YouTubeProgressBar.Size = new System.Drawing.Size(240, 23);
            this.YouTubeProgressBar.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "다운로드";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // YouTubePercentage
            // 
            this.YouTubePercentage.AutoSize = true;
            this.YouTubePercentage.Location = new System.Drawing.Point(26, 404);
            this.YouTubePercentage.Name = "YouTubePercentage";
            this.YouTubePercentage.Size = new System.Drawing.Size(21, 12);
            this.YouTubePercentage.TabIndex = 12;
            this.YouTubePercentage.Text = "0%";
            this.YouTubePercentage.Click += new System.EventHandler(this.label4_Click);
            // 
            // videoNameTextBox
            // 
            this.videoNameTextBox.Location = new System.Drawing.Point(67, 352);
            this.videoNameTextBox.Name = "videoNameTextBox";
            this.videoNameTextBox.Size = new System.Drawing.Size(240, 21);
            this.videoNameTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name =>";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(258, 379);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "둘다";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "(공백->기본 제목)";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(232, 428);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 17;
            this.TestButton.Text = "TestButton";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(68, 428);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "완료 사운드 제거";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuBar.Controls.Add(this.MenuBarButton4);
            this.MenuBar.Controls.Add(this.MenuBarButton3);
            this.MenuBar.Controls.Add(this.MenuBarButton2);
            this.MenuBar.Controls.Add(this.MenuBarButton1);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuBar.Location = new System.Drawing.Point(461, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(0, 538);
            this.MenuBar.TabIndex = 19;
            this.MenuBar.UseWaitCursor = true;
            // 
            // MenuBarButton4
            // 
            this.MenuBarButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MenuBarButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuBarButton4.Location = new System.Drawing.Point(0, 180);
            this.MenuBarButton4.Name = "MenuBarButton4";
            this.MenuBarButton4.Size = new System.Drawing.Size(0, 60);
            this.MenuBarButton4.TabIndex = 3;
            this.MenuBarButton4.Text = "예비3";
            this.MenuBarButton4.UseVisualStyleBackColor = true;
            this.MenuBarButton4.UseWaitCursor = true;
            // 
            // MenuBarButton3
            // 
            this.MenuBarButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MenuBarButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuBarButton3.Location = new System.Drawing.Point(0, 120);
            this.MenuBarButton3.Name = "MenuBarButton3";
            this.MenuBarButton3.Size = new System.Drawing.Size(0, 60);
            this.MenuBarButton3.TabIndex = 2;
            this.MenuBarButton3.Text = "예비2";
            this.MenuBarButton3.UseVisualStyleBackColor = true;
            this.MenuBarButton3.UseWaitCursor = true;
            // 
            // MenuBarButton2
            // 
            this.MenuBarButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MenuBarButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuBarButton2.Location = new System.Drawing.Point(0, 60);
            this.MenuBarButton2.Name = "MenuBarButton2";
            this.MenuBarButton2.Size = new System.Drawing.Size(0, 60);
            this.MenuBarButton2.TabIndex = 1;
            this.MenuBarButton2.Text = "예비1";
            this.MenuBarButton2.UseVisualStyleBackColor = true;
            this.MenuBarButton2.UseWaitCursor = true;
            // 
            // MenuBarButton1
            // 
            this.MenuBarButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MenuBarButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuBarButton1.Location = new System.Drawing.Point(0, 0);
            this.MenuBarButton1.Name = "MenuBarButton1";
            this.MenuBarButton1.Size = new System.Drawing.Size(0, 60);
            this.MenuBarButton1.TabIndex = 0;
            this.MenuBarButton1.Text = "유투브 다운";
            this.MenuBarButton1.UseVisualStyleBackColor = true;
            this.MenuBarButton1.UseWaitCursor = true;
            // 
            // MenuBarCheckBox
            // 
            this.MenuBarCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MenuBarCheckBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuBarCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuBarCheckBox.Checked = true;
            this.MenuBarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuBarCheckBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MenuBarCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuBarCheckBox.FlatAppearance.BorderSize = 0;
            this.MenuBarCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBarCheckBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBarCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuBarCheckBox.Location = new System.Drawing.Point(431, 0);
            this.MenuBarCheckBox.Name = "MenuBarCheckBox";
            this.MenuBarCheckBox.Size = new System.Drawing.Size(30, 538);
            this.MenuBarCheckBox.TabIndex = 4;
            this.MenuBarCheckBox.Text = "<";
            this.MenuBarCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuBarCheckBox.UseVisualStyleBackColor = false;
            this.MenuBarCheckBox.UseWaitCursor = true;
            this.MenuBarCheckBox.CheckedChanged += new System.EventHandler(this.MenuBarCheckBox_CheckedChanged);
            // 
            // MenuBarTimer
            // 
            this.MenuBarTimer.Interval = 10;
            this.MenuBarTimer.Tick += new System.EventHandler(this.MenuBarTimer_Tick);
            // 
            // YouTubeThumbnail
            // 
            this.YouTubeThumbnail.Location = new System.Drawing.Point(67, 174);
            this.YouTubeThumbnail.Name = "YouTubeThumbnail";
            this.YouTubeThumbnail.Size = new System.Drawing.Size(145, 104);
            this.YouTubeThumbnail.TabIndex = 21;
            this.YouTubeThumbnail.TabStop = false;
            // 
            // YouTubeInfoLabel
            // 
            this.YouTubeInfoLabel.AutoSize = true;
            this.YouTubeInfoLabel.Location = new System.Drawing.Point(218, 174);
            this.YouTubeInfoLabel.Name = "YouTubeInfoLabel";
            this.YouTubeInfoLabel.Size = new System.Drawing.Size(25, 12);
            this.YouTubeInfoLabel.TabIndex = 22;
            this.YouTubeInfoLabel.Text = "Info";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(313, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "추가";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "URL List";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "삭제";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // urlListBox
            // 
            this.urlListBox.FormattingEnabled = true;
            this.urlListBox.ItemHeight = 12;
            this.urlListBox.Location = new System.Drawing.Point(67, 80);
            this.urlListBox.Name = "urlListBox";
            this.urlListBox.Size = new System.Drawing.Size(240, 88);
            this.urlListBox.TabIndex = 26;
            this.urlListBox.SelectedIndexChanged += new System.EventHandler(this.urlListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 538);
            this.Controls.Add(this.urlListBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.YouTubeInfoLabel);
            this.Controls.Add(this.YouTubeThumbnail);
            this.Controls.Add(this.MenuBarCheckBox);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.videoNameTextBox);
            this.Controls.Add(this.YouTubePercentage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.YouTubeProgressBar);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.mp3Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MultiTool";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton mp4Button;
        private System.Windows.Forms.ProgressBar YouTubeProgressBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label YouTubePercentage;
        private System.Windows.Forms.TextBox videoNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton mp3Button;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Button MenuBarButton1;
        private System.Windows.Forms.CheckBox MenuBarCheckBox;
        private System.Windows.Forms.Button MenuBarButton4;
        private System.Windows.Forms.Button MenuBarButton3;
        private System.Windows.Forms.Button MenuBarButton2;
        private System.Windows.Forms.Timer MenuBarTimer;
        private System.Windows.Forms.PictureBox YouTubeThumbnail;
        private System.Windows.Forms.Label YouTubeInfoLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox urlListBox;
    }
}

