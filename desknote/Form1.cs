using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace desknote
{
    public partial class Form1 : Form
    {
        public Form1()
        {     //   public Form2 frm = new Form2();
              //    public Form3 frm1 = new Form3();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }      
        
        /*        public static int change(char[] str)
                {
                    int a=0;
                  for(int i = 0,j=str.Length; i < str.Length||j==0; i++,j--)
                    {
                       a+=Convert.ToInt32( Math.Pow(10, j))*str[0];
                    }
                    return a;
                }*/

        private void 设置或切换背景音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//创建一个文件对话框

            ofd.Filter = "图片文件|*.png|Mp3文件|*.gif|所有文件|*.*";//文件类型筛选器
            ofd.Title = "请选择文件";
            ofd.ShowDialog();//显示对话框

            string path = ofd.FileName;//获取选中的文件路径

            BackgroundImage = Image.FromFile(path);
        }

        private void hour_TextChanged(object sender, EventArgs e)
        {
            if (hour.Text == "")
                lblshow.Text = "时不能为空";
        }
        List<string> Listpath = new List<string>();
        //用于保存音乐文件的路径
        private void music_Click(object sender, EventArgs e)
        {
            //   Lookfrm(frm1);//打开界面
            OpenFileDialog ofd = new OpenFileDialog();//创建一个文件对话框
                                                      //           ofd.InitialDirectory = @"E:\音乐";//设置初始目录
            ofd.Filter = "音乐文件|*.wav|Mp3文件|*.mp3|所有文件|*.*";//文件类型筛选器
            ofd.Title = "请选择音乐";
            ofd.Multiselect = true;//允许多选
            ofd.ShowDialog();//显示对话框

            string[] path = ofd.FileNames;//获取选中的文件路径
                                          //  Listpath.Add("*\\Resources\aa.mp3");
            for (int i = 0; i < path.Length; i++)
            {
                String SongName = path[i].Remove(0, 6);
                String[] Singer = path[i].Remove(0, 6).Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                DateTime time = DateTime.Now;
                Listpath.Add(path[i]);//将路径保存到泛型集合中
                MusicBox1.Items.Add(path[i].Remove(0, 6));//将路径保存到listbox上
                                                          //   listBox1.Items.Add(path[i].Remove(0, 6));//将路径保存到listbox上
                String select = String.Format("select * from Music_File where SongName='{0}'", SongName);
                MessageBox.Show("本地歌曲添加成功");//测试



                //对数据库操作，不做了 
                /*              DateTable dt = DBhelper.Read(select);
                             if (dt.Rows.Count > 0)
                              {
                                  MessageBox.Show("本地已存在此歌曲");

                              }
                              else
                              {
                                  String music = String.Format("insert * from Music_File(SongName.Singer,URL,UploadTime)" +
                                      "values('{0}'.'{1}','{3}')", SongName, Singer[0], path[i], time);
                                  int rows = DBHelper.Write(music);
                                  if (rows > 0)
                                      MessageBox.Show("本地歌曲添加成功");
                                  else
                                      MessageBox.Show("歌曲添加失败");
                              }*/
            }
        }

        private void clock_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("可以设置一个小时:分钟:秒的闹钟");
        }

        private void AddClock_Click(object sender, EventArgs e)
        {

            //正则表达式确实格式
            Boolean b = Regex.IsMatch(hour.Text, "^/d$") || Regex.IsMatch(minuate.Text, "^/d$") || Regex.IsMatch(second.Text, "^/d$");
            // char[] str1 = text.Text.ToCharArray();
            // Boolean b = Regex.IsMatch(text.Text, "^/d/:/d:/d$");
            //  var str=str1.Split(':');
            // MessageBox.Show(""+str.Length);
            //  MessageBox.Show(str[0]);
            //   MessageBox.Show(hour.Text);
            /*     char[] hour1 = hour.Text.ToCharArray();

                 char[] minuate1 = minuate.Text.ToCharArray();

                 char[] second1 = second.Text.ToCharArray();*/


            if (true)
            {


                //MessageBox.Show("true");
                // Lookfrm(frm);
                //  Thread AlarmThread = new Thread(new ThreadStart(SetAlarm(change(hour1), change(minuate1), change(second1)));
                //  AlarmThread.Start();
                //  new Thread(() => SetAlarm(change(hour1), change(minuate1), change(second1))).Start();
                new Thread(AlarmThread => SetAlarm(Convert.ToInt32(hour.Text), Convert.ToInt32(minuate.Text), Convert.ToInt32(second.Text))).Start();
                //    MessageBox.Show(""+ Convert.ToInt32(hour.Text));
                MessageBox.Show("闹钟添加成功");
                Do.Text = "";
                hour.Text = minuate.Text = second.Text = "";
            }
            else
                MessageBox.Show("输入格式错误，请重新输入");
        }
        private void Lookfrm(Form frm)
        {
            //  if (frm == null) 
            // { 
            // frm= new Form2();
            //  frm.MdiParent = this;
            frm.Show();
            this.Hide();
            // }
        }
        // List<Thread> Threads;
        private void SetAlarm(int hour, int minuate, int second)
        {
            String str = Do.Text;
            Do.Text = "";//清空输入
            int time = hour * 3600 + minuate * 60 + second;
            DateTime date = DateTime.Now;
            date = date.AddSeconds(time);
            // MessageBox.Show(date.ToString());
            String str1 = "闹钟: " + date.ToString() + "您应该去：" + str;
            ClockBox1.Items.Add(str1);
            for (; ; )
            {
                /*                int HourNow = int.Parse(DateTime.Now.Hour.ToString());
                                int MinNow = int.Parse(DateTime.Now.Minute.ToString());
                                int SedNow = int.Parse(DateTime.Now.Second.ToString())*/
                ;
                if (date.ToString().Equals(DateTime.Now.ToString()))
                {
                    MessageBox.Show(DateTime.Now.ToString(), "时间到了！" + date.ToString() + "您应该去：" + str);
                    OpenMusic();
                    ClockBox1.Items.Remove(str1);
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = "现在的时间是：" + DateTime.Now;
        }

        private void minuate_TextChanged(object sender, EventArgs e)
        {
            char[] str = minuate.Text.ToCharArray();
            if (minuate.Text == "")
                lblshow.Text = "分不能为空";


            if (str.Length == 2)
            {
                int a = Convert.ToInt32(second.Text);
                if (a >= 60)
                {
                    minuate.Text = "";
                    lblshow.Text = "请输入小于60的整数";
                }
            }
            else
                lblshow.Text = "";
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            char[] str = second.Text.ToCharArray();
            if (second.Text == "")
                lblshow.Text = "秒不能为空";



            if (str.Length == 2)
            {


                int a = Convert.ToInt32(second.Text);
                if (a >= 60)
                {
                    second.Text = "";
                    lblshow.Text = "请输入小于60的整数";
                }
            }
            else
                lblshow.Text = "";
        }

        private void look_Click(object sender, EventArgs e)
        {
            ClockBox1.Visible = true;
        }

        private void MusicBox1_DoubleClick(object sender, EventArgs e)
        {
            //判断是否有音乐
            if (MusicBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择音乐");
                return;

            }
            OpenMusic();
        }

        private void Cmusic_Click(object sender, EventArgs e)
        {
            MusicBox1.Visible = true;
        }
        private void OpenMusic()
        {
            if (MusicBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择音乐");
                return;

            }
            //未选中行则默认第一行
            if (MusicBox1.SelectedItems.Count == 0)
            {
                MusicBox1.SelectedIndex = 0;

            }
            try
            {
                MusicPlayer.URL = Listpath[MusicBox1.SelectedIndex];//路径
                MusicPlayer.Ctlcontrols.play();//播放
                lblshow.Text = MusicPlayer.URL.Remove(0, 6);
                //    pb_play.Image = Image.FromFile(@"");

            }
            catch (Exception)
            {

            }
        }

        private void MusicBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusicBox1.Visible = false;
            OpenMusic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 播放音乐MToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 暂停开始SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MusicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                MusicPlayer.Ctlcontrols.pause();
            else
                MusicPlayer.Ctlcontrols.play();
        }

        private void ClockBox1_Click(object sender, EventArgs e)
        {


        }

        private void ClockBox1_Leave(object sender, EventArgs e)
        {
            ClockBox1.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            // 显示Form1
            Main main = new Main();
            main.ShowDialog();
        }
    }

}
