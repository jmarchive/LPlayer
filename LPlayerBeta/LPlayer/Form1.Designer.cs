namespace LPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.p_s = new System.Windows.Forms.Button();
            this.loopcheck = new System.Windows.Forms.CheckBox();
            this.stop = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.playedtime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 172);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(560, 180);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(560, 70);
            this.start.TabIndex = 1;
            this.start.Text = "选择声音";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                                                                 " +
    "            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "                                                                                 " +
    "            ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "                                                                                 " +
    "            ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "                                                                                 " +
    "            ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(563, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "                                                                                 " +
    "            ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 296);
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(561, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // p_s
            // 
            this.p_s.Enabled = false;
            this.p_s.Location = new System.Drawing.Point(14, 88);
            this.p_s.Name = "p_s";
            this.p_s.Size = new System.Drawing.Size(286, 56);
            this.p_s.TabIndex = 8;
            this.p_s.Text = "暂停";
            this.p_s.UseVisualStyleBackColor = true;
            this.p_s.Click += new System.EventHandler(this.p_s_Click);
            // 
            // loopcheck
            // 
            this.loopcheck.AutoSize = true;
            this.loopcheck.Location = new System.Drawing.Point(14, 150);
            this.loopcheck.Name = "loopcheck";
            this.loopcheck.Size = new System.Drawing.Size(72, 16);
            this.loopcheck.TabIndex = 9;
            this.loopcheck.Text = "循环播放";
            this.loopcheck.UseVisualStyleBackColor = true;
            this.loopcheck.CheckedChanged += new System.EventHandler(this.loopcheck_CheckedChanged);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(306, 88);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(140, 56);
            this.stop.TabIndex = 11;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(452, 88);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(120, 56);
            this.about.TabIndex = 12;
            this.about.Text = "关于...";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(518, 322);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 14);
            this.time.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(396, 326);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(0, 0);
            this.exit.TabIndex = 15;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // playedtime
            // 
            this.playedtime.AutoSize = true;
            this.playedtime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playedtime.Location = new System.Drawing.Point(11, 322);
            this.playedtime.Name = "playedtime";
            this.playedtime.Size = new System.Drawing.Size(42, 14);
            this.playedtime.TabIndex = 16;
            this.playedtime.Text = "0:0:0";
            // 
            // Form1
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.playedtime);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.time);
            this.Controls.Add(this.about);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.loopcheck);
            this.Controls.Add(this.p_s);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button p_s;
        private System.Windows.Forms.CheckBox loopcheck;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label playedtime;
    }
}

