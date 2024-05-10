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
using System.Media;
using System.Security.Policy;

namespace MultiTool
{
    public partial class Form1 : Form
    {
        const int SLIDING_WIDTH_MAX = 150;

        const int SLIDING_SPEED = 10;

        public Form1()
        {
            InitializeComponent();
            mp3Button.Checked = true;
            urlTextBox.Text = "";
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
        }

        private void button1_Click(object sender, EventArgs e)//붙여넣기
        {
            urlTextBox.Text = Clipboard.GetText();
        }
        private void button4_Click(object sender, EventArgs e)//추가
        {
            if (urlTextBox.Text != "") urlListBox.Items.Add(urlTextBox.Text);
            urlTextBox.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)//삭제
        {
            if(urlListBox.SelectedIndex!=-1) urlListBox.Items.RemoveAt(urlListBox.SelectedIndex);
        }
        private void button2_Click(object sender, EventArgs e)//파일 탐색기(경로지정)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "파일 경로 지정" })
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

            if (pathTextBox.Text == "") { MessageBox.Show("파일 경로를 지정해야합니다."); return; }
            
            if (urlTextBox.Text != "") urlListBox.Items.Add(urlTextBox.Text);
            urlTextBox.Text = "";

            if (urlListBox.Items.Count < 1) { MessageBox.Show("받을 영상이 없습니다."); return; }

            for (int i = 0; i < urlListBox.Items.Count; i++)
            {
                urlTextBox.Text = urlListBox.Items[i].ToString();
                try
                {
                    youtubeDownload(urlTextBox.Text, pathTextBox.Text, videoNameTextBox.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("error : " + urlTextBox.Text + "\n->" + err.Message);
                }

                YouTubeProgressBar.Value = 100;
                YouTubePercentage.Text = "100%";
                SystemSounds.Beep.Play();
            }
            urlListBox.Items.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            //SystemSounds.Beep.Play();
        }

        private void MenuBarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MenuBarCheckBox.Checked == true)
            {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                MenuBarButton1.Text = "";
                MenuBarButton2.Text = "";
                MenuBarButton3.Text = "";
                MenuBarButton4.Text = "";
                MenuBarCheckBox.Text = "<";
            }
            else
            {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                MenuBarButton1.Text = "유튜브 다운로더";
                MenuBarButton2.Text = "1";
                MenuBarButton3.Text = "2";
                MenuBarButton4.Text = "3";
                MenuBarCheckBox.Text = ">";
            }

            //타이머 시작
            MenuBarTimer.Start();
        }

        private void MenuBarTimer_Tick(object sender, EventArgs e)
        {
            MenuBar.Width += (MenuBarCheckBox.Checked ? -SLIDING_SPEED : SLIDING_SPEED);
            if(MenuBarCheckBox.Checked? MenuBar.Width<= 0 : MenuBar.Width >= SLIDING_WIDTH_MAX)
                MenuBarTimer.Stop();
        }

        private void urlListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
            //섬넬 체인지
            //info 체인지
        }
        //====================================================================================================================================
        private void youtubeDownload(string url,string path,string name)
        {
            var youtube = YouTube.Default; youtube.GetVideoAsync(url);
            var video = youtube.GetVideo(url);

            File.WriteAllBytes(path + @"\" + video.FullName, video.GetBytes());

            var inputFile = new MediaToolkit.Model.MediaFile { Filename = path + @"\" + video.FullName };
            var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{path + @"\" + video.FullName.Replace(".mp4", ".mp3")}" };

            using (var enging = new Engine())
            {
                enging.GetMetadata(inputFile);
                if (!mp4Button.Checked)
                {
                    enging.Convert(inputFile, outputFile);
                    if (name.Length != 0) File.Move($"{path + @"\" + video.FullName.Replace(".mp4", ".mp3")}", $"{path + @"\" + name + ".mp3"}");
                }
            }
            if (mp3Button.Checked) File.Delete(path + @"\" + video.FullName);
            else if (name.Length != 0) File.Move(path + @"\" + video.FullName, path + @"\" + name + ".mp4");

        }
    }
}
