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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.urlTextBox.Location = new System.Drawing.Point(67, 53);
            this.urlTextBox.Name = "textBox1";
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
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path =>";
            // 
            // textBox2
            // 
            this.pathTextBox.Location = new System.Drawing.Point(67, 80);
            this.pathTextBox.Name = "textBox2";
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
            this.button2.Location = new System.Drawing.Point(313, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "파일 탐색기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.mp3Button.AutoSize = true;
            this.mp3Button.Location = new System.Drawing.Point(68, 134);
            this.mp3Button.Name = "radioButton1";
            this.mp3Button.Size = new System.Drawing.Size(48, 16);
            this.mp3Button.TabIndex = 8;
            this.mp3Button.TabStop = true;
            this.mp3Button.Text = "MP3";
            this.mp3Button.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.mp4Button.AutoSize = true;
            this.mp4Button.Location = new System.Drawing.Point(164, 134);
            this.mp4Button.Name = "radioButton2";
            this.mp4Button.Size = new System.Drawing.Size(48, 16);
            this.mp4Button.TabIndex = 9;
            this.mp4Button.TabStop = true;
            this.mp4Button.Text = "MP4";
            this.mp4Button.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.YouTubeProgressBar.Location = new System.Drawing.Point(67, 154);
            this.YouTubeProgressBar.Name = "progressBar1";
            this.YouTubeProgressBar.Size = new System.Drawing.Size(240, 23);
            this.YouTubeProgressBar.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "다운로드";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.YouTubePercentage.AutoSize = true;
            this.YouTubePercentage.Location = new System.Drawing.Point(26, 159);
            this.YouTubePercentage.Name = "label4";
            this.YouTubePercentage.Size = new System.Drawing.Size(21, 12);
            this.YouTubePercentage.TabIndex = 12;
            this.YouTubePercentage.Text = "0%";
            this.YouTubePercentage.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.videoNameTextBox.Location = new System.Drawing.Point(67, 107);
            this.videoNameTextBox.Name = "textBox3";
            this.videoNameTextBox.Size = new System.Drawing.Size(240, 21);
            this.videoNameTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name =>";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(258, 134);
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
            this.label6.Location = new System.Drawing.Point(313, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "(공백->기본 제목)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

