using System;
using System.Windows.Forms;

namespace LPlayer
{
    public partial class Form1 : Form
    {
        bool ispause = false;
        public Form1() => InitializeComponent();

        private void exit_Click(object sender, EventArgs e) => Close();

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string a = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = a;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pause_start.Enabled = true;
                stop.Enabled = true;
                start.Enabled = false;
                pause_start.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void pause_start_Click(object sender, EventArgs e)
        {
            if(ispause == false)
            {
                pause_start.Text = "播放";
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                ispause = true;
            }
            else
            {
                pause_start.Text = "暂停";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                ispause = false;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            pause_start.Enabled = false;
            stop.Enabled = false;
            start.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            label3.Visible = !label3.Visible;
        }
    }
}
