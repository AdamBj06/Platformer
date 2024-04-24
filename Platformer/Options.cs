using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Options : Form
    {
        public static bool FullScreen = false;
        public static bool ShowFPS = false;
        private bool FullScreen_ = false;
        private bool ShowFPS_ = false;
        public Options()
        {
            InitializeComponent();
        }

        private void btn_FullScreen_Click(object sender, EventArgs e)
        {
            if (FullScreen_)
            {
                FullScreen_ = false;
                btn_FullScreen.BackColor = Color.White;
                return;
            }
            btn_FullScreen.BackColor = Color.Green;
            FullScreen_ = true;
        }

        private void btn_ShowFPS_Click(object sender, EventArgs e)
        {
            if (ShowFPS_)
            {
                ShowFPS_ = false;
                btn_ShowFPS.BackColor = Color.White;
                return;
            }
            btn_ShowFPS.BackColor = Color.Green;
            ShowFPS_ = true;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FullScreen = FullScreen_;
            ShowFPS = ShowFPS_;
        }

        private void Options_Shown(object sender, EventArgs e)
        {
            FullScreen_ = FullScreen;
            ShowFPS_ = ShowFPS;
            if (!FullScreen_)
            {
                btn_FullScreen.BackColor = Color.White;
            }
            else
            {
                btn_FullScreen.BackColor = Color.Green;
            }
            if (!ShowFPS_)
            {
                btn_ShowFPS.BackColor = Color.White;
            }
            else
            {
                btn_ShowFPS.BackColor = Color.Green;
            }
        }

        private void Options_Resize(object sender, EventArgs e)
        {
            Width = 500;
            Height = 600;
        }
    }
}
