using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class PlayerDec : Form
    {
        Player p1 = Form1.p1;
        public PlayerDec()
        {
            InitializeComponent();
        }

        private void pct_Back_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            Close();
        }

        private void PlayerDec_Resize(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 600;
        }

        private void pct_red_Click(object sender, EventArgs e)
        {
            p1.Color = Color.Red;
        }

        private void pct_blue_Click(object sender, EventArgs e)
        {
            p1.Color = Color.Blue;
        }

        private void pct_yellow_Click(object sender, EventArgs e)
        {
            p1.Color = Color.Yellow;
        }

        private void pct_lime_Click(object sender, EventArgs e)
        {
            p1.Color = Color.Lime;
        }
    }
}
