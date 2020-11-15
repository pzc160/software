using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTraining
{
    public partial class Gameover : Form
    {
        int score;
        int targetscore;
        int highestscore;
        int traintype;    
        int levelnum;
        int k;

        public Gameover(int score, int targetscore, int highestscore, int traintype, int levelnum)
        {
            InitializeComponent();
            this.score = score;
            this.targetscore = targetscore;
            this.highestscore = highestscore;
            this.traintype = traintype;
            this.levelnum = levelnum;
            label1.Parent = pictureBox3;

            if (score < targetscore)
            {
                pictureBox1.Visible = true;
                //you lose!             
            }
            else if (score > highestscore)
            {
                pictureBox3.Visible = true;
                //you win!新纪录：
                highestscore = score;
                label1.Text = highestscore.ToString();
                Data_access.UpdateHscore(traintype, levelnum, highestscore);
                //更新数据库
            }
            else
            {
                pictureBox2.Visible = true;
                //you win!
            }

        }

        public Gameover(int k)
        {
            InitializeComponent();
            label1.Parent = pictureBox3;
            this.k = k;

            if (k == 1)
            {
                pictureBox1.Visible = true;
                //you lose! 
            }
            if (k == 2)
            {
                pictureBox2.Visible = true;
                //you win!
            }
        }

    }
}
