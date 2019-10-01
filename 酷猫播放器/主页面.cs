using System;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace 酷猫播放器
{
    public partial class 主页面 : Form
    {
        public 主页面()
        {
            InitializeComponent();
            this.Opacity = 0.95;            
            this.TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
        }

        //注册热键的api 
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk);

        //进度条
        private void progress()
        {
            int floatPostion = (int)(this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            progressBar1.Value = floatPostion;
            歌词.Location = new Point(176, 180 - floatPostion);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //注册热键(窗体句柄,热键ID,辅助键,实键)
            RegisterHotKey(this.Handle, 334, 0, Keys.PageUp);
            RegisterHotKey(this.Handle, 335, 0, Keys.PageDown);
            RegisterHotKey(this.Handle, 336, 0, Keys.Escape);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = new System.Drawing.Bitmap(@"bg.jpg");
            this.listBox1.Hide();
            progressBar1.Minimum = 0;
            axWindowsMediaPlayer1.URL = "login.wav";
            axWindowsMediaPlayer1.settings.autoStart = true;//自动开始
            Thread thread = new Thread(delegate() {
                read();
            });
            thread.IsBackground = true;
            thread.Start();

            
        }

        //拦截窗体消息
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312:    //这个是window消息定义的注册的热键消息 
                    if (m.WParam.ToString().Equals("334"))  //上一曲 
                    {
                        Up();
                    }
                    else if (m.WParam.ToString().Equals("335"))  //下一曲
                    {
                        Next();
                    }
                    else if (m.WParam.ToString().Equals("336")) //关闭
                    {
                        this.timer2.Enabled = true;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        //添加文件夹
        private void showfiles(string path, ListBox listBox1)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            int length = 0;
            foreach (FileInfo f in dir.GetFiles("*.mp*"))
            {
                length++;
                addlist(length + " " + f.Name, f.FullName);
            }
            foreach (DirectoryInfo f in dir.GetDirectories())
            {
                showfiles(f.FullName, listBox1);
            }
            foreach (FileInfo f in dir.GetFiles("*.rmvb"))
            {
                length++;
                addlist(length + " " + f.Name, f.FullName);
            }
            foreach (DirectoryInfo f in dir.GetDirectories())
            {
                showfiles(f.FullName, listBox1);
            }
        }
        //把路径和文件名添加到列表上
        private void addlist(string name, string vm)
        {
            this.列表.Items.Add(name);
            this.listBox1.Items.Add(vm);
        }
        int all;
        //获取总时间
        private void allTime()
        {
            if (this.axWindowsMediaPlayer1.currentMedia != null)
            {
                string i = this.axWindowsMediaPlayer1.currentMedia.durationString;
                label3.Text = i;
                progressBar1.Value = 0;
                all = (int)(this.axWindowsMediaPlayer1.currentMedia.duration);
                progressBar1.Maximum = all;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }
        //播放/暂停
        private void PlayOrPause()
        {
            if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPlaying")
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                allTime();
                播放或暂停.BackgroundImageLayout = ImageLayout.Stretch;
                播放或暂停.BackgroundImage = new System.Drawing.Bitmap(@"Pause.png");
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                播放或暂停.BackgroundImageLayout = ImageLayout.Stretch;
                播放或暂停.BackgroundImage = new System.Drawing.Bitmap(@"Play.png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            volumeMiues();

        }
        //减小音量
        private void volumeMiues()
        {
            axWindowsMediaPlayer1.settings.volume -= 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            volumeAdd();
        }
        //增加音量
        private void volumeAdd()
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }
        //获取当前播放时间
        private void time()
        {
            string w = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            label2.Text = w;

            int i = (int)(this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

            if (i >= all - 1)
            {
                Next();
                // MessageBox.Show("asdf");
            }
        }
        //1秒钟刷新一次时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            time();
            progress();
        }
        //声道加
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.balance += 10;
        }
        //声道减
        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.balance -= 10;
        }
        //获取信息
        private void button8_Click(object sender, EventArgs e)
        {
            
        }
        //模式
        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        //设为全屏
        private void button11_Click(object sender, EventArgs e)
        {
            
        }
        //快进
        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }
        //快退
        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
        }
        //打开
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Next();
        }
        //下一曲
        private void Next()
        {

            列表.SelectedIndex = 列表.SelectedIndex + 1;//listbox中选择的数加1
            string path = this.listBox1.Items[列表.SelectedIndex].ToString();
            axWindowsMediaPlayer1.URL = path;//添加到WindowsMediaPlayer1的URL
            lrcShow(path);
            播放或暂停.BackgroundImageLayout = ImageLayout.Stretch;
            播放或暂停.BackgroundImage = new System.Drawing.Bitmap(@"Play.png");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Up();
        }
        //上一曲
        private void Up()
        {
            //allTime();
            列表.SelectedIndex = 列表.SelectedIndex - 1;//listbox中选择的数加1
            string path = this.listBox1.Items[列表.SelectedIndex].ToString();
            axWindowsMediaPlayer1.URL = path;//添加到WindowsMediaPlayer1的URL
            lrcShow(path);
            播放或暂停.BackgroundImageLayout = ImageLayout.Stretch;
            播放或暂停.BackgroundImage = new System.Drawing.Bitmap(@"Play.png");
        }
        //清空列表
        private void button15_Click(object sender, EventArgs e)
        {
            
        }
        //播放状态改变时发生该时间
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            allTime();
            label1.Text = axWindowsMediaPlayer1.status;
        }

        //esc隐藏窗体
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) //激活回车键
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;

            if (msg.Msg == WM_KEYDOWN | msg.Msg == WM_SYSKEYDOWN)
            {
                switch (keyData)
                {
                    case Keys.Escape:
                        this.Hide();//csc隐藏窗体
                        break;
                }
            }
            return false;
        }
        //保存数据
        private void saveData()
        {
            FileStream fs = new FileStream("temp.dll", FileMode.OpenOrCreate);
            //保存路径可以自己更改
            StreamWriter sw = new StreamWriter(fs);
            foreach (object item in listBox1.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            fs.Close();

            FileStream fs1 = new FileStream("temp1.dll", FileMode.OpenOrCreate);
            //保存路径可以自己更改
            StreamWriter sw1 = new StreamWriter(fs1);
            foreach (object item1 in 列表.Items)
            {
                sw1.WriteLine(item1.ToString());
            }
            sw1.Close();
            fs1.Close();
        }

        //初始化播放列表
        private void read()
        {
            StreamReader file = new StreamReader("temp.dll", System.Text.Encoding.UTF8);
            string s = "";
            while (s != null)
            {
                s = file.ReadLine();
                if (s != null && !s.Equals(""))
                {
                    listBox1.Items.Add(s);
                }
            }
            file.Close();

            StreamReader file1 = new StreamReader("temp1.dll", System.Text.Encoding.UTF8);
            string s1 = "";
            while (s1 != null)
            {
                s1 = file1.ReadLine();
                if (s1 != null && !s1.Equals(""))
                {
                    列表.Items.Add(s1);
                }
            }
            file1.Close();

            WebRequest wr = WebRequest.Create("http://www.baidu.com");
            WebResponse response = wr.GetResponse();
            Stream stream = response.GetResponseStream();

            Encoding ec = Encoding.UTF8;

            StreamReader reader = new StreamReader(stream, ec);
            string htmlText = reader.ReadToEnd();

            run(htmlText);

            foreach (string item in ls)
            {
                listBox1.Items.Add("http://www.baidu.com" + item.Substring(0, item.IndexOf("\"")));
                列表.Items.Add(item.Substring(item.IndexOf("\"") + 6));
                if (listBox1.Items.Count > 150) break;
            }
        }
        List<string> ls = new List<string>();
        private string run(string htmlText)
        {
            try
            {
                htmlText = htmlText.Substring(htmlText.IndexOf("<a href=\"/d/") + 11);
                string htmlTexts = htmlText.Substring(0, htmlText.IndexOf("</tt></a></td>"));
                ls.Add(htmlTexts);
                return run(htmlText);
            }
            catch (Exception)
            {

                return null;
            }

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            int index2 = this.列表.SelectedIndex;
            string path = this.listBox1.Items[index2].ToString();
            axWindowsMediaPlayer1.URL = path;
            lrcShow(path);
        }
        //歌词显示
        private void lrcShow(string path)
        {
            try
            {
                int index = path.IndexOf(".");
                string url = path.Substring(0, index);
                StreamReader file = new StreamReader(url + ".lrc", System.Text.Encoding.Default);
                string s = "";
                s = file.ReadToEnd();
                歌词.Text = s;
                file.Close();
            }
            catch (Exception)
            {
                歌词.Text = "没有歌词";
            }
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();//释放资源
            Application.Exit();
        }

        private void 下一曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void 上一曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Up();
        }

        private void 播放暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }
        int io = 1;
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //if (io != 1)
            //{
            //    this.Show();
            //    io = 1;
            //}
            //else
            //{
            //    this.timer2.Enabled = true;
            //    io = 0;
            //}
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Next();
            }
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = this.listBox1.Items[列表.SelectedIndex].ToString();
            axWindowsMediaPlayer1.URL = path;
        }

        private void 请插入移动设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(soure, name + fileName, true);
            }
            catch (Exception)
            {
                MessageBox.Show("复制出错！");
            }

        }

        private void 打开文件所在目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        string soure;
        string fileName;
        string name;
        private void 发送到ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            soure = this.listBox1.Items[列表.SelectedIndex].ToString();
            DriveInfo[] di = DriveInfo.GetDrives();
            foreach (DriveInfo d in di)
            {
                if (d.DriveType == DriveType.Removable)
                {
                    name = d.Name;
                    this.请插入移动设备ToolStripMenuItem.ForeColor = Color.Black;
                    this.请插入移动设备ToolStripMenuItem.Text = name;
                    fileName = soure.Substring(soure.LastIndexOf(@"\") + 1);
                }
            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            this.label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            this.label5.ForeColor = Color.White ;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }
  
        bool beginMove = false;
        int currentXPosition = 0;
        int currentYPosition = 0;
        private void Play_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;
                this.Top += MousePosition.Y - currentYPosition;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Play_MouseDown(object sender, MouseEventArgs e)
        {
            beginMove = true;
            currentXPosition = MousePosition.X;
            currentYPosition = MousePosition.Y;
        }

        private void Play_MouseUp(object sender, MouseEventArgs e)
        {
            beginMove = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            PlayOrPause();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Up();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "文件类型(*.wmv;*.mp3:*.rmvb)|*.wmv;*.mp3;*.rmvb";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                listBox1.Items.Add(path);
                列表.Items.Add(openFile.FileName);
                axWindowsMediaPlayer1.URL = path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void 添加文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fbd.ShowDialog() == DialogResult.OK)
            {
                string path = this.fbd.SelectedPath;
                showfiles(path, listBox1);
                saveData();
            }
        }

        private void 调整模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.uiMode == "none")
            {
                axWindowsMediaPlayer1.uiMode = "full";
            }
            else if (axWindowsMediaPlayer1.uiMode == "full")
            {
                axWindowsMediaPlayer1.uiMode = "mini";
            }
            else if (axWindowsMediaPlayer1.uiMode == "mini")
            {
                axWindowsMediaPlayer1.uiMode = "none";
            }
        }

        private void 设为全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.列表.Items.Clear();
            saveData();
        }

        private void 文件属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string author = axWindowsMediaPlayer1.currentMedia.getItemInfo("Author");
            string title = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
            MessageBox.Show("标  题：" + title + "\n" + "艺术家：" + author);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;            
            }
            else if (this.Opacity == 0)
            {
                this.Hide();
                this.timer2.Enabled = false;
                this.Opacity = 0.95;     
            }
            else this.timer2.Enabled = false;
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
