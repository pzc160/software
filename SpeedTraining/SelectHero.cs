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
    public partial class SelectHero : Form
    {
        private int heronum;  //选择英雄序号
        public int Heronum {
            get { return this.heronum; }
        }

        public SelectHero()
        {
            InitializeComponent();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            heronum = 1;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            pictureBox2.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
