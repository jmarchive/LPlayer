using System;
using System.IO;
using System.Text.RegularExpressions;
using Shell32;
using System.Windows.Forms;

namespace LPlayer
{
    public partial class Form1 : Form
    {
        int playsecond = 0;
        int playminute = 0;
        int playhour = 0;
        bool isplaying = false;
        bool loop = false;
        string pathname = "";
        char[] split = { };
        char[] split2 = { };

        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
                return;
            }
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            p_s.Enabled = true;
            stop.Enabled = true;
            string dirName = Path.GetDirectoryName(openFileDialog1.FileName);
            string SongName = Path.GetFileName(openFileDialog1.FileName);
            FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(dirName);
            FolderItem item = dir.ParseName(SongName);
            string SongTime = Regex.Match(dir.GetDetailsOf(item, -1), "\\d:\\d{2}:\\d{2}").Value;
            time.Text = SongTime;
            Text = $"{SongName} - LPlayer";
            pathname = openFileDialog1.FileName;
            openFileDialog1.FileName = "";
            timer1.Enabled = true;
            string timenumber = Regex.Replace(SongTime, @"[^0-9]+", "");
            split = timenumber.ToCharArray();
            for(int i = split.Length;i == 0 || i > 0;i--)
            {
                split2[split.Length - i] = split[i];
            }
            for(int i=split.Length;i == 0 || i > 0;i--)
            {
                MessageBox.Show(split[i].ToString());
            }
            for (int i = split2.Length; i == 0 || i > 0; i--)
            {
                MessageBox.Show(split2[i].ToString());
            }
            p_s.Focus();
            isplaying = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            playsecond += 1;
            if(playsecond == 60.0)
            {
                playminute++;
                playsecond -= 60;
            }
            if(playminute == 60.0)
            {
                playhour++;
                playminute -= 60;
            }
            playedtime.Text = $"{playhour}:{playminute}:{playsecond}";
        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exit_Click(object sender, EventArgs e) => Close();

        private void p_s_Click(object sender, EventArgs e)
        {
            if(isplaying==true)
            {
                p_s.Text = "播放";
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                isplaying = false;
                timer1.Enabled = false;
                p_s.Focus();
            }
            else
            {
                p_s.Text = "暂停";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                isplaying = true;
                timer1.Enabled = true;
                p_s.Focus();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            p_s.Enabled = false;
            stop.Enabled = false;
            timer1.Enabled = false;
            playsecond = 0;
            playminute = 0;
            playhour = 0;
            start.Focus();
        }

        private void loopcheck_CheckedChanged(object sender, EventArgs e)
        {
            loop = !loop;
        }

        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            //1=停止 2=暂停 3=播放 6=正在缓冲 9=正在连接 10=准备就绪
            switch ((int)axWindowsMediaPlayer1.playState)
            {
                case 1:
                    {
                        if (loop == true)
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            stop.Enabled = false;
                            timer1.Enabled = false;
                            p_s.Enabled = false;
                            time.Text = "";
                            playedtime.Text = "0:0:0";
                            axWindowsMediaPlayer1.URL = "";
                        }
                    break;
                    }
            }
        }
    }
}