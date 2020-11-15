using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace SpeedTraining
{
    public partial class Level : Form
    {
        int score;   //本关分数
        int targetscore;    //目标分数
        int highestscore;   //关卡最高分
        int traintype;    //训练类型
        int levelnum;    //关卡等级
        int heronum;   //选择英雄序号，为0时表示该参数没用
        int speed; //速度等级
        int count = 15; //按键亮起的总次数
        int k = 0;  //count-1时，k+1,已亮起按键次数
        int n;  //亮起按键的索引
        int[] indexs; //按照特定索引顺序亮起按键
        PictureBox[] pb;
        Random rd = new Random();

        public Level(int traintype, int levelnum,int heronum)
        {
            InitializeComponent();

            this.traintype = traintype;
            this.levelnum = levelnum;
            this.heronum = heronum;

            pb = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11 };

            for(int i = 0; i < 11; i++)
            {
                pb[i].Visible = false;
            }

              LevelInit();               
            
        }

 //       public Level(int traintype, int levelnum)
   //     {
     //       this.traintype = traintype;
       //     this.levelnum = levelnum;
       // }

        public void LevelInit()
        {
            SqlDataReader reader = Data_access.QueryLevelData(traintype, levelnum); //根据训练类型和关卡等级读取关卡数据
            while (reader.Read())
            {
                speed = reader.GetInt32(2);
                targetscore = reader.GetInt32(3);
                highestscore = reader.GetInt32(5);
            }
            reader.Close();

            if (traintype == 1 || traintype == 3)
            {
                timer1.Interval = 1500 / speed;
                timer1.Enabled = true;
            } //设置按键亮起速度


            label5.Text = targetscore.ToString();
            label7.Text = highestscore.ToString();
        }

        private int SetOrder()
        {
            if (traintype == 1)  n = rd.Next(0, 11);
            else if(heronum == 1)
            {
                indexs = new int[] { 0, 8, 7, 10, 3, 9, 1, 7, 10 };
                int i = k % indexs.Length;
                n = indexs[i];                
            }
            return n;
        }//设置按键亮起顺序

        private void timer1_Tick(object sender, EventArgs e)
        {
            n = SetOrder();
            pb[n].Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }//控制train 1、3按键亮起的顺序


        private void timer2_Tick(object sender, EventArgs e)
        {
            pb[n].Visible = false;
            count--;  //按键亮起一次，计数减1
            k++; //已亮起数加1
            timer2.Enabled = false;
            timer1.Enabled = true;
            if (count == 0)
            {
                LevelOver();
            }
        }  //控制按键亮起


        public void LevelOver()
        {         
            if (traintype == 1 || traintype == 3)
            {
               timer1.Enabled = false;
               timer2.Enabled = false;
            }
            Gameover gameover = new Gameover(score, targetscore, highestscore, traintype, levelnum);
            gameover.ShowDialog();
        }

        private void Level_KeyDown(object sender, KeyEventArgs e)
        {
            Keys temp = e.KeyData;
            int t;   //加减分数
            switch (temp) 
            {
                case Keys.W:
                    t = pb[0].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.A:
                    t = pb[1].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.S:
                    t = pb[2].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.D:
                    t = pb[3].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.Z:
                    t = pb[4].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.X:
                    t = pb[5].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.C:
                    t = pb[6].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.J:
                    t = pb[7].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.K:
                    t = pb[8].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.L:
                    t = pb[9].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                case Keys.Q:
                    t = pb[10].Visible ? 20 : -10;
                    score += t;
                    label6.Text = score.ToString();
                    break;
                default: break;
            }            
        }

    }
}
