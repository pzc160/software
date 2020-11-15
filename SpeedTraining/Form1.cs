using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeedTraining;
using SpeedTraining.Properties;

namespace 换装训练
{
    public partial class Form1 : Form
    {
        const int eqnum = 15;//装备个数
        const int preparetime = 3; //准备时间
        const int maxRank = 5; //最高关卡数
        bool perfect = false;//用于判定是否击中
        int cur_eqnum = 1;//同时亮着的装备的个数
        int[] rd = new int[3];//用于指示哪些装备是亮着的,最高难度为同时可以有3个
        Bitmap[] eqpic =
        {
            Resources.eq1,Resources.eq2,Resources.eq3,
            Resources.eq4,Resources.eq5,Resources.eq6,
            Resources.eq7,Resources.eq8,Resources.eq9,
            Resources.eq10,Resources.eq11,Resources.eq12,
            Resources.eq13,Resources.eq14,Resources.eq15
        };
        int score = 0; //本关分数
        int scores = 0;  //总分
        int targetscore = 1000;    //过关分数
        int rank = 1; //关卡
        int cur_prepare = preparetime;
        int miss;
        Random rds = new Random();
        PictureBox[] pb;//用于展示图片
        //string con;
        //OleDbConnection connn;
        public Form1()
        {
            InitializeComponent();
            pb = new PictureBox[] { 
                pictureBox1, pictureBox2, pictureBox3, pictureBox4,
                pictureBox5, pictureBox6, pictureBox7, pictureBox8, 
                pictureBox9,pictureBox10,pictureBox11,pictureBox12,
                pictureBox13,pictureBox14,pictureBox15
            };
            pcbdisabled();
        }
        //初始化成员变量
        private void init()
        {
            pcbenabled();
            miss = 0;
            score = scores = 0;
            targetscore = 1000;
            rank = 1;
            timer3.Interval = 40;
        }
        //用于控制picBox是否可以点
        public void pcbenabled()
        {
            for (int j = 0; j < eqnum; j++)
            {
                pb[j].Enabled = true;
            }
        }
        public void pcbdisabled()
        {
            for (int j = 0; j < eqnum; j++)
            {
                pb[j].Enabled = false;
            }
        }
        //将图片转化为黑白图片
        public Bitmap BWPic(Bitmap mybm, int width, int height)
        {
            Bitmap bm = new Bitmap(width, height);//初始化一个Bitmap对象，用来记录处理后的图片
            int x, y, result;//x,y是循环次数，result是记录处理后的像素值
            Color pixel;

            for (x = 0; x < width; x++)
            {
                for (y = 0; y < height; y++)
                {
                    pixel = mybm.GetPixel(x, y);//获取当前坐标的像素值
                    result = (pixel.R + pixel.G + pixel.B) / 3;//取红绿蓝三色的平均值
                    //绘图，把处理后的值赋值到刚才定义的bm对象里面
                    bm.SetPixel(x, y, Color.FromArgb(result, result, result));
                }
            }
            return bm;//返回黑白图片
        }
        private void game_set()
        {
            //将所有的转变为黑白的
            for(int i = 0; i < eqnum; i++)
            {
                pb[i].BackgroundImage =
                BWPic((Bitmap)eqpic[i], eqpic[i].Width, eqpic[i].Height);//变为黑白的
            }
            cur_eqnum = 1;
            if (rank >= 3) cur_eqnum = 2;
            if (rank >= 6) cur_eqnum = 3;
            perfect = true;
            miss = 0;
            prepare.Visible = true;
            progressBar.Width = 300;
            timer2.Enabled = true;
            label3.Text = Convert.ToString(targetscore);
        }
        private void hit(int i)
        {
            perfect = true;
            label1.Text = Convert.ToString(scores+=100);
            label2.Text = Convert.ToString(score+=100);
            pb[i].BackgroundImage =
                BWPic((Bitmap)eqpic[i],eqpic[i].Width,eqpic[i].Height);//变为黑白的
        }
        private void _miss()
        {
            miss += 1;
            label1.Text = Convert.ToString(scores -= 50);
            label2.Text = Convert.ToString(score -= 50);
        }
        private void gamelevel()
        {
            if (score >= targetscore)
            {
                pcbdisabled();
               
                Gameover gameover = new Gameover(2);
                gameover.ShowDialog();

                //MessageBox.Show("perfect：" + (score+miss*50) / 100 + "  " + "miss：" + miss,"返回", MessageBoxButtons.OK);
                this.start.Visible = true;
                this.next.Visible = true;
                score = 0;
                targetscore += 200;
                label2.Text = score.ToString();
            }
            else
            {
                Gameover gameover = new Gameover(1);
                gameover.ShowDialog();
                //MessageBox.Show("perfect：" + (score+miss*50)/ 100 + "  " + "miss：" + miss
                //    + "\nGame Over！", "返回", MessageBoxButtons.OK);
                score = scores = 0;
                rank = 0;
                _rank.Text = "关卡:" + rank;
                progressBar.Width = 300;
                start.Visible = true;
                pcbdisabled();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < cur_eqnum; i++)
            {
                //时间到，将前面一个图片转换为黑白
                pb[rd[i]].BackgroundImage = 
                    BWPic((Bitmap)eqpic[rd[i]], eqpic[rd[i]].Width, eqpic[rd[i]].Height);//变为黑白的
                if (!perfect) _miss();
                //决定下一个对象
                rd[i] = rds.Next(0, eqnum);
                //将下一个变为彩色
                pb[rd[i]].BackgroundImage = eqpic[rd[i]];
                perfect = false;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < cur_eqnum; j++)
            {
                if ((sender as PictureBox).Name == pb[rd[j]].Name)
                {
                    hit(rd[j]);
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            init();
            _rank.Text = "关卡:" + rank;
            start.Visible = false;
            game_set();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("是否退出游戏?", "退出", MessageBoxButtons.OKCancel)) == DialogResult.OK)
            {
                Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            prepare.Text = cur_prepare.ToString();
            cur_prepare -= 1;
            if (cur_prepare == -1)
            {
                prepare.Visible = false;
                pcbenabled();
                timer2.Enabled = false;
                timer3.Enabled = true;
                timer1.Enabled = true;
                progressBar.Visible = true;
                cur_prepare = 3;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar.Width -= 1;
            if (progressBar.Width == 300)
                progressBar.BackColor = Color.FromArgb(45, 207, 75);
            if (progressBar.Width == 100)
                progressBar.BackColor = Color.FromArgb(207, 45, 79);
            if (progressBar.Width == 0)
            {
                progressBar.BackColor = Color.FromArgb(45, 207, 75);
                timer1.Enabled = false;
                timer3.Enabled = false;
                gamelevel();//进行结算
            }
        }

        private void next_Click(object sender, EventArgs e)
        {//增加难度，修改图标
            rank++;
            timer3.Interval -= 2;
            game_set();
            next.Visible = false;
            start.Visible = false;
            _rank.Text = "关卡:" + rank;
        }

    }
}
