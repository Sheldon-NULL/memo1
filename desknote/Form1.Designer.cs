﻿
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
            this.设置背景音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.播放音乐MToolStripMenuItem,
            this.设置背景音乐ToolStripMenuItem,
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(503, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 播放音乐MToolStripMenuItem
            // 
            this.播放音乐MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂停开始SToolStripMenuItem,
            this.下一首NToolStripMenuItem,
            this.上一首FToolStripMenuItem});
            this.播放音乐MToolStripMenuItem.Name = "播放音乐MToolStripMenuItem";
            this.播放音乐MToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.播放音乐MToolStripMenuItem.Text = "播放音乐（&M）";
            this.播放音乐MToolStripMenuItem.Click += new System.EventHandler(this.播放音乐MToolStripMenuItem_Click);
            // 
            // 暂停开始SToolStripMenuItem
            // 
            this.暂停开始SToolStripMenuItem.Name = "暂停开始SToolStripMenuItem";
            this.暂停开始SToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.暂停开始SToolStripMenuItem.Text = "暂停/开始（&S）";
            this.暂停开始SToolStripMenuItem.Click += new System.EventHandler(this.暂停开始SToolStripMenuItem_Click);
            // 
            // 下一首NToolStripMenuItem
            // 
            this.下一首NToolStripMenuItem.Name = "下一首NToolStripMenuItem";
            this.下一首NToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.下一首NToolStripMenuItem.Text = "下一首（&N）";
            // 
            // 上一首FToolStripMenuItem
            // 
            this.上一首FToolStripMenuItem.Name = "上一首FToolStripMenuItem";
            this.上一首FToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.上一首FToolStripMenuItem.Text = "上一首（&F）";
            // 
            // 设置背景音乐ToolStripMenuItem
            // 
            this.设置背景音乐ToolStripMenuItem.Name = "设置背景音乐ToolStripMenuItem";
            this.设置背景音乐ToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.设置背景音乐ToolStripMenuItem.Text = "设置背景图片（&P）";
            this.设置背景音乐ToolStripMenuItem.Click += new System.EventHandler(this.设置或切换背景音乐ToolStripMenuItem_Click);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clock.Location = new System.Drawing.Point(18, 38);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(83, 33);
            this.clock.TabIndex = 1;
            this.clock.Text = "闹钟";
            this.clock.MouseHover += new System.EventHandler(this.clock_MouseHover);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(189, 38);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(26, 18);
            this.Lable1.TabIndex = 2;
            this.Lable1.Text = "时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(123, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "事件：";
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(136, 35);
            this.hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(46, 28);
            this.hour.TabIndex = 6;
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            // 
            // minuate
            // 
            this.minuate.Location = new System.Drawing.Point(268, 35);
            this.minuate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minuate.Name = "minuate";
            this.minuate.Size = new System.Drawing.Size(44, 28);
            this.minuate.TabIndex = 7;
            this.minuate.TextChanged += new System.EventHandler(this.minuate_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(386, 35);
            this.second.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(34, 28);
            this.second.TabIndex = 8;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(209, 108);
            this.Do.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(280, 28);
            this.Do.TabIndex = 9;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(18, 78);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(0, 18);
            this.lblshow.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(0, 107);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 28);
            this.Save.TabIndex = 11;
            this.Save.Text = "本地保存";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // music
            // 
            this.music.Location = new System.Drawing.Point(0, 142);
            this.music.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(116, 56);
            this.music.TabIndex = 12;
            this.music.Text = "添加音乐";
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // Cmusic
            // 
            this.Cmusic.Location = new System.Drawing.Point(136, 145);
            this.Cmusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmusic.Name = "Cmusic";
            this.Cmusic.Size = new System.Drawing.Size(110, 53);
            this.Cmusic.TabIndex = 13;
            this.Cmusic.Text = "选择音乐";
            this.Cmusic.UseVisualStyleBackColor = true;
            this.Cmusic.Click += new System.EventHandler(this.Cmusic_Click);
            // 
            // AddClock
            // 
            this.AddClock.Location = new System.Drawing.Point(253, 145);
            this.AddClock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddClock.Name = "AddClock";
            this.AddClock.Size = new System.Drawing.Size(112, 53);
            this.AddClock.TabIndex = 14;
            this.AddClock.Text = "添加闹钟";
            this.AddClock.UseVisualStyleBackColor = true;
            this.AddClock.Click += new System.EventHandler(this.AddClock_Click);
            // 
            // look
            // 
            this.look.Location = new System.Drawing.Point(388, 143);
            this.look.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(115, 53);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(503, 31);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Timer
            // 
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(64, 24);
            this.Timer.Text = "时间：";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 24);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusicBox1
            // 
            this.MusicBox1.FormattingEnabled = true;
            this.MusicBox1.ItemHeight = 18;
            this.MusicBox1.Location = new System.Drawing.Point(21, 206);
            this.MusicBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MusicBox1.Name = "MusicBox1";
            this.MusicBox1.Size = new System.Drawing.Size(451, 364);
            this.MusicBox1.TabIndex = 17;
            this.MusicBox1.Visible = false;
            this.MusicBox1.SelectedIndexChanged += new System.EventHandler(this.MusicBox1_SelectedIndexChanged);
            this.MusicBox1.DoubleClick += new System.EventHandler(this.MusicBox1_DoubleClick);
            // 
            // ClockBox1
            // 
            this.ClockBox1.FormattingEnabled = true;
            this.ClockBox1.ItemHeight = 18;
            this.ClockBox1.Location = new System.Drawing.Point(21, 220);
            this.ClockBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClockBox1.Name = "ClockBox1";
            this.ClockBox1.Size = new System.Drawing.Size(438, 346);
            this.ClockBox1.TabIndex = 18;
            this.ClockBox1.Visible = false;
            this.ClockBox1.Click += new System.EventHandler(this.ClockBox1_Click);
            this.ClockBox1.Leave += new System.EventHandler(this.ClockBox1_Leave);
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(406, 60);
            this.MusicPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.MusicPlayer.TabIndex = 19;
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
            this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            // 
            // 打印预览VToolStripMenuItem
            // 
            this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
            this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
            this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自定义CToolStripMenuItem,
            this.选项OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自定义CToolStripMenuItem
            // 
            this.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem";
            this.自定义CToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.自定义CToolStripMenuItem.Text = "自定义(&C)";
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜索SToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜索SToolStripMenuItem
            // 
            this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
            this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.搜索SToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 601);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sheldon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem 设置背景音乐ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}