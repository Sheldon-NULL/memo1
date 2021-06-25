
namespace desknote
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放音乐MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停开始SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一首NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一首FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置或切换背景音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clock = new System.Windows.Forms.Label();
            this.Lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            this.minuate = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.Do = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.music = new System.Windows.Forms.Button();
            this.Cmusic = new System.Windows.Forms.Button();
            this.AddClock = new System.Windows.Forms.Button();
            this.look = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MusicBox1 = new System.Windows.Forms.ListBox();
            this.ClockBox1 = new System.Windows.Forms.ListBox();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.播放音乐MToolStripMenuItem,
            this.设置或切换背景音乐ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 播放音乐MToolStripMenuItem
            // 
            this.播放音乐MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂停开始SToolStripMenuItem,
            this.下一首NToolStripMenuItem,
            this.上一首FToolStripMenuItem});
            this.播放音乐MToolStripMenuItem.Name = "播放音乐MToolStripMenuItem";
            this.播放音乐MToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.播放音乐MToolStripMenuItem.Text = "播放音乐（&M）";
            this.播放音乐MToolStripMenuItem.Click += new System.EventHandler(this.播放音乐MToolStripMenuItem_Click);
            // 
            // 暂停开始SToolStripMenuItem
            // 
            this.暂停开始SToolStripMenuItem.Name = "暂停开始SToolStripMenuItem";
            this.暂停开始SToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.暂停开始SToolStripMenuItem.Text = "暂停/开始（&S）";
            this.暂停开始SToolStripMenuItem.Click += new System.EventHandler(this.暂停开始SToolStripMenuItem_Click);
            // 
            // 下一首NToolStripMenuItem
            // 
            this.下一首NToolStripMenuItem.Name = "下一首NToolStripMenuItem";
            this.下一首NToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.下一首NToolStripMenuItem.Text = "下一首（&N）";
            // 
            // 上一首FToolStripMenuItem
            // 
            this.上一首FToolStripMenuItem.Name = "上一首FToolStripMenuItem";
            this.上一首FToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.上一首FToolStripMenuItem.Text = "上一首（&F）";
            // 
            // 设置或切换背景音乐ToolStripMenuItem
            // 
            this.设置或切换背景音乐ToolStripMenuItem.Name = "设置或切换背景音乐ToolStripMenuItem";
            this.设置或切换背景音乐ToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.设置或切换背景音乐ToolStripMenuItem.Text = "设置或切换背景图片（&P）";
            this.设置或切换背景音乐ToolStripMenuItem.Click += new System.EventHandler(this.设置或切换背景音乐ToolStripMenuItem_Click);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clock.Location = new System.Drawing.Point(16, 32);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(70, 28);
            this.clock.TabIndex = 1;
            this.clock.Text = "闹钟";
            this.clock.MouseHover += new System.EventHandler(this.clock_MouseHover);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(168, 32);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(22, 15);
            this.Lable1.TabIndex = 2;
            this.Lable1.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(109, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "事件：";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(121, 29);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(41, 25);
            this.hour.TabIndex = 6;
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            // 
            // minuate
            // 
            this.minuate.Location = new System.Drawing.Point(238, 29);
            this.minuate.Name = "minuate";
            this.minuate.Size = new System.Drawing.Size(40, 25);
            this.minuate.TabIndex = 7;
            this.minuate.TextChanged += new System.EventHandler(this.minuate_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(343, 29);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(31, 25);
            this.second.TabIndex = 8;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(186, 90);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(249, 25);
            this.Do.TabIndex = 9;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(16, 65);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(0, 15);
            this.lblshow.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 89);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "本地保存";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // music
            // 
            this.music.Location = new System.Drawing.Point(0, 118);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(103, 47);
            this.music.TabIndex = 12;
            this.music.Text = "添加音乐";
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // Cmusic
            // 
            this.Cmusic.Location = new System.Drawing.Point(121, 121);
            this.Cmusic.Name = "Cmusic";
            this.Cmusic.Size = new System.Drawing.Size(98, 44);
            this.Cmusic.TabIndex = 13;
            this.Cmusic.Text = "选择音乐";
            this.Cmusic.UseVisualStyleBackColor = true;
            this.Cmusic.Click += new System.EventHandler(this.Cmusic_Click);
            // 
            // AddClock
            // 
            this.AddClock.Location = new System.Drawing.Point(225, 121);
            this.AddClock.Name = "AddClock";
            this.AddClock.Size = new System.Drawing.Size(100, 44);
            this.AddClock.TabIndex = 14;
            this.AddClock.Text = "添加闹钟";
            this.AddClock.UseVisualStyleBackColor = true;
            this.AddClock.Click += new System.EventHandler(this.AddClock_Click);
            // 
            // look
            // 
            this.look.Location = new System.Drawing.Point(345, 119);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(102, 44);
            this.look.TabIndex = 15;
            this.look.Text = "查看闹钟";
            this.look.UseVisualStyleBackColor = true;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Timer,
            this.time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(447, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Timer
            // 
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(54, 20);
            this.Timer.Text = "时间：";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusicBox1
            // 
            this.MusicBox1.FormattingEnabled = true;
            this.MusicBox1.ItemHeight = 15;
            this.MusicBox1.Location = new System.Drawing.Point(19, 172);
            this.MusicBox1.Name = "MusicBox1";
            this.MusicBox1.Size = new System.Drawing.Size(401, 304);
            this.MusicBox1.TabIndex = 17;
            this.MusicBox1.Visible = false;
            this.MusicBox1.SelectedIndexChanged += new System.EventHandler(this.MusicBox1_SelectedIndexChanged);
            this.MusicBox1.DoubleClick += new System.EventHandler(this.MusicBox1_DoubleClick);
            // 
            // ClockBox1
            // 
            this.ClockBox1.FormattingEnabled = true;
            this.ClockBox1.ItemHeight = 15;
            this.ClockBox1.Location = new System.Drawing.Point(19, 183);
            this.ClockBox1.Name = "ClockBox1";
            this.ClockBox1.Size = new System.Drawing.Size(390, 289);
            this.ClockBox1.TabIndex = 18;
            this.ClockBox1.Visible = false;
            this.ClockBox1.Click += new System.EventHandler(this.ClockBox1_Click);
            this.ClockBox1.Leave += new System.EventHandler(this.ClockBox1_Leave);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(406, 60);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.MusicPlayer.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 501);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.ClockBox1);
            this.Controls.Add(this.MusicBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.look);
            this.Controls.Add(this.AddClock);
            this.Controls.Add(this.Cmusic);
            this.Controls.Add(this.music);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.second);
            this.Controls.Add(this.minuate);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sheldon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放音乐MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置或切换背景音乐ToolStripMenuItem;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox minuate;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox Do;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button music;
        private System.Windows.Forms.Button Cmusic;
        private System.Windows.Forms.Button AddClock;
        private System.Windows.Forms.Button look;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox MusicBox1;
        private System.Windows.Forms.ListBox ClockBox1;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripMenuItem 暂停开始SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一首NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一首FToolStripMenuItem;
    }
}