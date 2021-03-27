using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Net;

namespace WordsKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        string[] oriwords;//存所有的单词
        string[][] words = new string[12][];//存12个单词
        List<Label> listLable = new List<Label>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
            //打开单词文件
            FileStream fs = new FileStream("words.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string ori = sr.ReadToEnd().Replace("\r", "");
            oriwords = ori.Split('\n');
            //生成12个随机的单词
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                int index = random.Next(0, oriwords.Length - 1);
                words[i] = oriwords[index].Split(' ');
            }

            string http = "http://dict.youdao.com/speech?audio=";
            for (int i = 0; i < 12; i++)
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(http + words[i][0]);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                Stream st = resp.GetResponseStream();
                Stream so = new FileStream(i + ".mp3", FileMode.Create);

                long totalDownlodeByte = 0;
                byte[] by = new byte[1024];
                int oSize = st.Read(by, 0, by.Length);
                while (oSize > 0)
                {
                    totalDownlodeByte += oSize;
                    Application.DoEvents();
                    so.Write(by, 0, oSize);

                    oSize = st.Read(by, 0, by.Length);
                }
                so.Flush();
                so.Close();
                st.Close();
            }
            
            //生成12个label
            int k = 0;
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label label = new Label();
                    label.Size = new Size(455, 300);
                    label.Location = new Point(20 + j * 475, 20 + i * 320);
                    label.BackColor = Color.FromArgb(36, 255, 255, 255);
                    label.Font = new Font("微软雅黑", 28);
                    label.ForeColor = Color.White;
                    label.Image = Properties.Resources._lock;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Visible = true;
                    label.Tag = k++;
                    label.Click += lbl_Click;
                    label.MouseEnter += lbl_MouseEnter;
                    label.MouseLeave += lbl_MouseLeave;
                    this.Controls.Add(label);
                    listLable.Add(label);
                }
            }
        }

        int correct = 0;
        private void paintOption()//随机生成选项
        {
            Random random = new Random();
            string A = oriwords[random.Next(0, oriwords.Length - 1)].Split(' ')[1];
            string B = oriwords[random.Next(0, oriwords.Length - 1)].Split(' ')[1];
            string C = oriwords[random.Next(0, oriwords.Length - 1)].Split(' ')[1];
            string D = oriwords[random.Next(0, oriwords.Length - 1)].Split(' ')[1];

            lblA.Text = "A. " + A;
            lblB.Text = "B. " + B;
            lblC.Text = "C. " + C;
            lblD.Text = "D. " + D;

            correct = random.Next(1, 4);
            string correctword = words[presentWord][1];
            switch (correct)
            {
                case 1:
                    lblA.Text = "A. " + correctword;
                    break;
                case 2:
                    lblB.Text = "B. " + correctword;
                    break;
                case 3:
                    lblC.Text = "C. " + correctword;
                    break;
                case 4:
                    lblD.Text = "D. " + correctword;
                    break;
                default:
                    break;
            }
        }

        private void pnlOption_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (presentWord == -1)
            {
                g.DrawString("点击任意一张单词卡", new Font("微软雅黑", 28), new SolidBrush(Color.White), new Point(780, 20));
            }
        }

        bool isClick = false;

        private void lblA_Click(object sender, EventArgs e)
        {
            if (true == isClick)
            {
                isClick = false;
                Label label = (Label)sender;
                int index = int.Parse((string)label.Tag);
                if (index == correct)
                {
                    label.Text = "正确";
                    locker[presentWord] = 2;
                    presentLabel.Text = words[presentWord][0] + "\n" + words[presentWord][1];
                }
                else
                {
                    label.Text = "错误";
                    locker[presentWord] = 3;
                    presentLabel.Text = "10";
                }
            }
        }

        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (locker[i] == 3)
                {
                    listLable[i].Text = (int.Parse(listLable[i].Text) - 1) + "";
                    if (int.Parse(listLable[i].Text) == 0)
                    {
                        listLable[i].Text = "";
                        listLable[i].Image = Properties.Resources._lock;
                        locker[i] = 0;
                    }
                }
                else if (locker[i] == 2)
                {
                    count++;
                    if (count == 12)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            count = 0;
        }

        private void lblA_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(36, 255, 255, 255);
        }

        private void lblA_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        int[] locker = new int[12];//0：锁定，1：正在处理，2：正确，3：倒计时
        int presentWord = -1;
        Label presentLabel = new Label();

        private void lbl_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int index = (int)label.Tag;//所点击的label的索引

            if (1 == locker[index] || 2 == locker[index])
            {
                axWindowsMediaPlayer.URL = index + ".mp3";
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
            if (presentWord != -1 && locker[presentWord] == 1)//如果正在处理的单词没有选择答案
            {
                return;
            }
            if (0 == locker[index])//如果当前label是锁着的
            {
                isClick = true;
                presentLabel = label;
                presentWord = index;
                locker[index] = 1;
                label.Image = null;
                label.Text = words[index][0];
                pnlOption.Invalidate();
                paintOption();
                lblA.Show();
                lblB.Show();
                lblC.Show();
                lblD.Show();
                axWindowsMediaPlayer.URL = index + ".mp3";
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(72, 255, 255, 255);
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(36, 255, 255, 255);
        }
    }
}
