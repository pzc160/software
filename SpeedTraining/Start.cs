using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 换装训练;

namespace SpeedTraining
{
    public partial class Start : Form
    {
        int traintype;  //选择训练类型
        int levelnum;   //选择关卡等级
        int heronum = 0;    //选择英雄序号，为0时表示该参数没用

        public Start()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            //Username username = new Username();
            //username.ShowDialog();
            train1.Visible = true;
            train2.Visible = true;
            train3.Visible = true;
            returnbox.Visible = true;

        }

        private void train1_Click(object sender, EventArgs e)
        {
            traintype = 1;

            train1.Visible = false;
            train2.Visible = false;
            train3.Visible = false;

            Level1.Visible = true;
            Level2.Visible = true;
            Level3.Visible = true;
        }

        private void train2_Click(object sender, EventArgs e)
        {
            traintype = 2;

            train1.Visible = false;
            train2.Visible = false;
            train3.Visible = false;

            Level1.Visible = true;
            Level2.Visible = true;
            Level3.Visible = true;

        }

        private void train3_Click(object sender, EventArgs e)
        {
            traintype = 3;

            SelectHero selecthero = new SelectHero();
            selecthero.ShowDialog();
            heronum = selecthero.Heronum;

            train1.Visible = false;
            train2.Visible = false;
            train3.Visible = false;

            Level1.Visible = true;
            Level2.Visible = true;
            Level3.Visible = true;

        }

        private void Level1_Click(object sender, EventArgs e)
        {
            levelnum = 1;
            this.Visible = false;
            if (traintype == 1 || traintype == 3)
            {
                Level level = new Level(traintype,levelnum, heronum);
                level.ShowDialog();
            }
            if (traintype == 2)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            this.Visible = true;
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            levelnum = 2;
            this.Visible = false;
            if (traintype == 1 || traintype == 3)
            {
                Level level = new Level(traintype, levelnum, heronum);
                level.ShowDialog();
            }
            this.Visible = true;
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            levelnum = 3;
            this.Visible = false;
            if (traintype == 1 || traintype == 3)
            {
                Level level = new Level(traintype, levelnum, heronum);
                level.ShowDialog();
            }
            this.Visible = true;
        }

        private void returnbox_Click(object sender, EventArgs e)
        {
            if(train1.Visible == true)
            {
                train1.Visible = false;
                train2.Visible = false;
                train3.Visible = false;
                returnbox.Visible = false;
            }
            else if(Level1.Visible == true)
            {
                traintype = 0;

                Level1.Visible = false;
                Level2.Visible = false;
                Level3.Visible = false;

                train1.Visible = true;
                train2.Visible = true;
                train3.Visible = true;
            }
        }

    
    }
}
