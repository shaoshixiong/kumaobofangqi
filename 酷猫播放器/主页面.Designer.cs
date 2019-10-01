namespace 酷猫播放器
{
    partial class 主页面
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主页面));
            this.播放 = new System.Windows.Forms.Button();
            this.音量减 = new System.Windows.Forms.Button();
            this.音量加 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.声道加 = new System.Windows.Forms.Button();
            this.声道减 = new System.Windows.Forms.Button();
            this.快进 = new System.Windows.Forms.Button();
            this.快退 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请插入移动设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件所在目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调整模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设为全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签页控件 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.首页标签页 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.歌词标签页 = new System.Windows.Forms.TabPage();
            this.歌词 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.上一曲 = new System.Windows.Forms.Panel();
            this.播放或暂停 = new System.Windows.Forms.Panel();
            this.下一曲 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.搜索 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.标签页控件.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.歌词标签页.SuspendLayout();
            this.SuspendLayout();
            // 
            // 播放
            // 
            this.播放.BackColor = System.Drawing.Color.Transparent;
            this.播放.Location = new System.Drawing.Point(47, 495);
            this.播放.Name = "播放";
            this.播放.Size = new System.Drawing.Size(75, 23);
            this.播放.TabIndex = 1;
            this.播放.Text = "播放/暂停";
            this.播放.UseVisualStyleBackColor = false;
            this.播放.Click += new System.EventHandler(this.button1_Click);
            // 
            // 音量减
            // 
            this.音量减.BackColor = System.Drawing.Color.Transparent;
            this.音量减.Location = new System.Drawing.Point(675, 539);
            this.音量减.Name = "音量减";
            this.音量减.Size = new System.Drawing.Size(75, 23);
            this.音量减.TabIndex = 2;
            this.音量减.Text = "音量-";
            this.音量减.UseVisualStyleBackColor = false;
            this.音量减.Click += new System.EventHandler(this.button4_Click);
            // 
            // 音量加
            // 
            this.音量加.BackColor = System.Drawing.Color.Transparent;
            this.音量加.Location = new System.Drawing.Point(832, 539);
            this.音量加.Name = "音量加";
            this.音量加.Size = new System.Drawing.Size(75, 23);
            this.音量加.TabIndex = 3;
            this.音量加.Text = "音量+";
            this.音量加.UseVisualStyleBackColor = false;
            this.音量加.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "00.00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(280, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "00.00";
            // 
            // 声道加
            // 
            this.声道加.BackColor = System.Drawing.Color.Transparent;
            this.声道加.Location = new System.Drawing.Point(204, 539);
            this.声道加.Name = "声道加";
            this.声道加.Size = new System.Drawing.Size(75, 23);
            this.声道加.TabIndex = 10;
            this.声道加.Text = "声道+";
            this.声道加.UseVisualStyleBackColor = false;
            this.声道加.Click += new System.EventHandler(this.button2_Click);
            // 
            // 声道减
            // 
            this.声道减.BackColor = System.Drawing.Color.Transparent;
            this.声道减.Location = new System.Drawing.Point(47, 539);
            this.声道减.Name = "声道减";
            this.声道减.Size = new System.Drawing.Size(75, 23);
            this.声道减.TabIndex = 11;
            this.声道减.Text = "声道-";
            this.声道减.UseVisualStyleBackColor = false;
            this.声道减.Click += new System.EventHandler(this.button7_Click);
            // 
            // 快进
            // 
            this.快进.BackColor = System.Drawing.Color.Transparent;
            this.快进.Location = new System.Drawing.Point(361, 539);
            this.快进.Name = "快进";
            this.快进.Size = new System.Drawing.Size(75, 23);
            this.快进.TabIndex = 16;
            this.快进.Text = "快进";
            this.快进.UseVisualStyleBackColor = false;
            this.快进.Click += new System.EventHandler(this.button12_Click);
            // 
            // 快退
            // 
            this.快退.BackColor = System.Drawing.Color.Transparent;
            this.快退.Location = new System.Drawing.Point(518, 539);
            this.快退.Name = "快退";
            this.快退.Size = new System.Drawing.Size(75, 23);
            this.快退.TabIndex = 16;
            this.快退.Text = "快退";
            this.快退.UseVisualStyleBackColor = false;
            this.快退.Click += new System.EventHandler(this.button13_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(47, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 424);
            this.listBox1.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 10);
            this.progressBar1.TabIndex = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "酷猫播放器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.播放暂停ToolStripMenuItem,
            this.下一曲ToolStripMenuItem,
            this.上一曲ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 114);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 播放暂停ToolStripMenuItem
            // 
            this.播放暂停ToolStripMenuItem.Name = "播放暂停ToolStripMenuItem";
            this.播放暂停ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.播放暂停ToolStripMenuItem.Text = "播放/暂停";
            this.播放暂停ToolStripMenuItem.Click += new System.EventHandler(this.播放暂停ToolStripMenuItem_Click);
            // 
            // 下一曲ToolStripMenuItem
            // 
            this.下一曲ToolStripMenuItem.Name = "下一曲ToolStripMenuItem";
            this.下一曲ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.下一曲ToolStripMenuItem.Text = "下一曲[&D]";
            this.下一曲ToolStripMenuItem.Click += new System.EventHandler(this.下一曲ToolStripMenuItem_Click);
            // 
            // 上一曲ToolStripMenuItem
            // 
            this.上一曲ToolStripMenuItem.Name = "上一曲ToolStripMenuItem";
            this.上一曲ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.上一曲ToolStripMenuItem.Text = "上一曲";
            this.上一曲ToolStripMenuItem.Click += new System.EventHandler(this.上一曲ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // 列表
            // 
            this.列表.BackColor = System.Drawing.Color.White;
            this.列表.ContextMenuStrip = this.contextMenuStrip2;
            this.列表.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.列表.ForeColor = System.Drawing.Color.DimGray;
            this.列表.FormattingEnabled = true;
            this.列表.Location = new System.Drawing.Point(47, 98);
            this.列表.Name = "列表";
            this.列表.Size = new System.Drawing.Size(268, 420);
            this.列表.TabIndex = 24;
            this.列表.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.播放ToolStripMenuItem,
            this.发送到ToolStripMenuItem,
            this.打开文件所在目录ToolStripMenuItem,
            this.打开文件ToolStripMenuItem,
            this.添加文件夹ToolStripMenuItem,
            this.调整模式ToolStripMenuItem,
            this.设为全屏ToolStripMenuItem,
            this.清空列表ToolStripMenuItem,
            this.文件属性ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(171, 202);
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.播放ToolStripMenuItem.Text = "播放";
            this.播放ToolStripMenuItem.Click += new System.EventHandler(this.播放ToolStripMenuItem_Click);
            // 
            // 发送到ToolStripMenuItem
            // 
            this.发送到ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请插入移动设备ToolStripMenuItem});
            this.发送到ToolStripMenuItem.Name = "发送到ToolStripMenuItem";
            this.发送到ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.发送到ToolStripMenuItem.Text = "发送到";
            this.发送到ToolStripMenuItem.MouseHover += new System.EventHandler(this.发送到ToolStripMenuItem_MouseHover);
            // 
            // 请插入移动设备ToolStripMenuItem
            // 
            this.请插入移动设备ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.请插入移动设备ToolStripMenuItem.Name = "请插入移动设备ToolStripMenuItem";
            this.请插入移动设备ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.请插入移动设备ToolStripMenuItem.Text = "请插入移动设备";
            this.请插入移动设备ToolStripMenuItem.Click += new System.EventHandler(this.请插入移动设备ToolStripMenuItem_Click);
            // 
            // 打开文件所在目录ToolStripMenuItem
            // 
            this.打开文件所在目录ToolStripMenuItem.Name = "打开文件所在目录ToolStripMenuItem";
            this.打开文件所在目录ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.打开文件所在目录ToolStripMenuItem.Text = "打开文件所在目录";
            this.打开文件所在目录ToolStripMenuItem.Click += new System.EventHandler(this.打开文件所在目录ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 添加文件夹ToolStripMenuItem
            // 
            this.添加文件夹ToolStripMenuItem.Name = "添加文件夹ToolStripMenuItem";
            this.添加文件夹ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.添加文件夹ToolStripMenuItem.Text = "添加文件夹";
            this.添加文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加文件夹ToolStripMenuItem_Click);
            // 
            // 调整模式ToolStripMenuItem
            // 
            this.调整模式ToolStripMenuItem.Name = "调整模式ToolStripMenuItem";
            this.调整模式ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.调整模式ToolStripMenuItem.Text = "调整模式";
            this.调整模式ToolStripMenuItem.Click += new System.EventHandler(this.调整模式ToolStripMenuItem_Click);
            // 
            // 设为全屏ToolStripMenuItem
            // 
            this.设为全屏ToolStripMenuItem.Name = "设为全屏ToolStripMenuItem";
            this.设为全屏ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.设为全屏ToolStripMenuItem.Text = "设为全屏";
            this.设为全屏ToolStripMenuItem.Click += new System.EventHandler(this.设为全屏ToolStripMenuItem_Click);
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // 文件属性ToolStripMenuItem
            // 
            this.文件属性ToolStripMenuItem.Name = "文件属性ToolStripMenuItem";
            this.文件属性ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.文件属性ToolStripMenuItem.Text = "文件属性";
            this.文件属性ToolStripMenuItem.Click += new System.EventHandler(this.文件属性ToolStripMenuItem_Click);
            // 
            // 标签页控件
            // 
            this.标签页控件.Controls.Add(this.tabPage1);
            this.标签页控件.Controls.Add(this.tabPage2);
            this.标签页控件.Controls.Add(this.歌词标签页);
            this.标签页控件.Location = new System.Drawing.Point(320, 74);
            this.标签页控件.Name = "标签页控件";
            this.标签页控件.SelectedIndex = 0;
            this.标签页控件.Size = new System.Drawing.Size(596, 444);
            this.标签页控件.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.首页标签页);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // 首页标签页
            // 
            this.首页标签页.Dock = System.Windows.Forms.DockStyle.Fill;
            this.首页标签页.Location = new System.Drawing.Point(3, 3);
            this.首页标签页.MinimumSize = new System.Drawing.Size(20, 20);
            this.首页标签页.Name = "首页标签页";
            this.首页标签页.Size = new System.Drawing.Size(582, 412);
            this.首页标签页.TabIndex = 25;
            this.首页标签页.Url = new System.Uri("http://www.kugou.com/", System.UriKind.Absolute);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MV";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(582, 412);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // 歌词标签页
            // 
            this.歌词标签页.BackgroundImage = global::酷猫播放器.Properties.Resources._5;
            this.歌词标签页.Controls.Add(this.歌词);
            this.歌词标签页.Controls.Add(this.shapeContainer1);
            this.歌词标签页.Location = new System.Drawing.Point(4, 22);
            this.歌词标签页.Name = "歌词标签页";
            this.歌词标签页.Padding = new System.Windows.Forms.Padding(3);
            this.歌词标签页.Size = new System.Drawing.Size(588, 418);
            this.歌词标签页.TabIndex = 2;
            this.歌词标签页.Text = "歌词";
            this.歌词标签页.UseVisualStyleBackColor = true;
            // 
            // 歌词
            // 
            this.歌词.AutoSize = true;
            this.歌词.ForeColor = System.Drawing.Color.Yellow;
            this.歌词.Location = new System.Drawing.Point(176, 180);
            this.歌词.Name = "歌词";
            this.歌词.Size = new System.Drawing.Size(53, 12);
            this.歌词.TabIndex = 0;
            this.歌词.Text = "没有歌词";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(582, 412);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 586;
            this.lineShape1.Y1 = 183;
            this.lineShape1.Y2 = 183;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(948, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 29;
            // 
            // 上一曲
            // 
            this.上一曲.BackColor = System.Drawing.Color.Transparent;
            this.上一曲.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("上一曲.BackgroundImage")));
            this.上一曲.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.上一曲.Location = new System.Drawing.Point(86, 49);
            this.上一曲.Name = "上一曲";
            this.上一曲.Size = new System.Drawing.Size(40, 40);
            this.上一曲.TabIndex = 30;
            this.上一曲.Click += new System.EventHandler(this.panel2_Click);
            // 
            // 播放或暂停
            // 
            this.播放或暂停.BackColor = System.Drawing.Color.Transparent;
            this.播放或暂停.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("播放或暂停.BackgroundImage")));
            this.播放或暂停.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.播放或暂停.Location = new System.Drawing.Point(160, 49);
            this.播放或暂停.Name = "播放或暂停";
            this.播放或暂停.Size = new System.Drawing.Size(40, 40);
            this.播放或暂停.TabIndex = 30;
            this.播放或暂停.Click += new System.EventHandler(this.panel3_Click);
            // 
            // 下一曲
            // 
            this.下一曲.BackColor = System.Drawing.Color.Transparent;
            this.下一曲.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("下一曲.BackgroundImage")));
            this.下一曲.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.下一曲.Location = new System.Drawing.Point(234, 49);
            this.下一曲.Name = "下一曲";
            this.下一曲.Size = new System.Drawing.Size(40, 40);
            this.下一曲.TabIndex = 30;
            this.下一曲.Click += new System.EventHandler(this.panel4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 21);
            this.textBox1.TabIndex = 31;
            // 
            // 搜索
            // 
            this.搜索.Location = new System.Drawing.Point(837, 33);
            this.搜索.Name = "搜索";
            this.搜索.Size = new System.Drawing.Size(75, 23);
            this.搜索.TabIndex = 32;
            this.搜索.Text = "搜索";
            this.搜索.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // 主页面
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 587);
            this.Controls.Add(this.搜索);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.下一曲);
            this.Controls.Add(this.播放或暂停);
            this.Controls.Add(this.上一曲);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.标签页控件);
            this.Controls.Add(this.列表);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.快退);
            this.Controls.Add(this.快进);
            this.Controls.Add(this.声道减);
            this.Controls.Add(this.声道加);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.音量加);
            this.Controls.Add(this.音量减);
            this.Controls.Add(this.播放);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "主页面";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Play_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Play_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Play_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.标签页控件.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.歌词标签页.ResumeLayout(false);
            this.歌词标签页.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button 播放;
        private System.Windows.Forms.Button 音量减;
        private System.Windows.Forms.Button 音量加;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button 声道加;
        private System.Windows.Forms.Button 声道减;
        private System.Windows.Forms.Button 快进;
        private System.Windows.Forms.Button 快退;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox 列表;
        private System.Windows.Forms.TabControl 标签页控件;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage 歌词标签页;
        private System.Windows.Forms.Label 歌词;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下一曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        protected System.Windows.Forms.WebBrowser 首页标签页;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请插入移动设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件所在目录ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel 上一曲;
        private System.Windows.Forms.Panel 播放或暂停;
        private System.Windows.Forms.Panel 下一曲;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调整模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设为全屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件属性ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 搜索;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
    }
}

