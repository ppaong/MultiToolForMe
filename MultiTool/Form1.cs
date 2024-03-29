using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MultiTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mp3Button.Checked = true;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
        }

        private void button1_Click(object sender, EventArgs e)//붙여넣기
        {
            urlTextBox.Text = Clipboard.GetText();
        }

        private void button2_Click(object sender, EventArgs e)//파일 탐색기(경로지정)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = fdb.SelectedPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//다운로드
        {
            YouTubeProgressBar.Value = 0;
            YouTubePercentage.Text = "0%";

            var youtube = YouTube.Default; youtube.GetVideoAsync(urlTextBox.Text);
            var video = youtube.GetVideo(urlTextBox.Text);
            File.WriteAllBytes(pathTextBox.Text + @"\" + video.FullName, video.GetBytes());

            var inputFile = new MediaToolkit.Model.MediaFile { Filename = pathTextBox.Text + @"\" + video.FullName };
            var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{pathTextBox.Text + @"\" + video.FullName.Replace(".mp4",".mp3")}" };

            using (var enging = new Engine())
            {
                enging.GetMetadata(inputFile);
                if (!mp4Button.Checked){
                    enging.Convert(inputFile, outputFile);
                    if (videoNameTextBox.Text.Length != 0) File.Move($"{pathTextBox.Text + @"\" + video.FullName.Replace(".mp4", ".mp3")}", $"{pathTextBox.Text + @"\" + videoNameTextBox.Text + ".mp3"}");
                }
            }
            if (mp3Button.Checked) File.Delete(pathTextBox.Text + @"\" + video.FullName);
            else if (videoNameTextBox.Text.Length != 0) File.Move(pathTextBox.Text + @"\" + video.FullName, pathTextBox.Text + @"\" + videoNameTextBox.Text + ".mp4");

            YouTubeProgressBar.Value = 100;
            YouTubePercentage.Text = "100%";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
