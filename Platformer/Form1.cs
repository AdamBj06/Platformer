using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {//https://www.youtube.com/watch?v=ypELBpiVZ1Y
        public static Player p1 = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Visible = false;
            GamePlay gm = new GamePlay();
            gm.Owner = this;
            gm.Show();
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void btn_PlayerDec_Click(object sender, EventArgs e)
        {
            Visible = false;
            PlayerDec playerDec = new PlayerDec();
            playerDec.Owner = this;
            playerDec.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 600;
        }
    }
}
