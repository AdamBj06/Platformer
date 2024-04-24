using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class GamePlay : Form
    {
        Graphics g;
        Level tutorial = new Level();
        Level lv1 = new Level();
        Level[] levels = new Level[2];
        
        public GamePlay()
        {
            InitializeComponent();
            InitializeChambers();
            levels[0] = tutorial;
            levels[1] = lv1;
            currentLevel = levels[0];
        }
        private void InitializeChambers()//1000x600
        {
            const int h = 600;//va fino al bordo
            const int l = 1000;
            const int liqThns = 20;//spessore dei liquidi
            const int spikesz = 20;

            g = CreateGraphics();

            //Level 0 (tutorial)
            Chamber c1 = new Chamber(0, 0);
            c1.HitBoxes.Add(new Rectangle(0, 480, l, h));
            c1.HitBoxes.Add(new Rectangle(666, 420, l, h));
            c1.HitBoxes.Add(new Rectangle(0, 0, 150, 150));
            c1.HitBoxes.Add(new Rectangle(350, 0, l, 150));
            c1.Doors.Add(new Rectangle(50, 430, 25, 50));
            c1.LabelFont = new Font("Arial", 10);
            string tuto1 = "Click 'E' to\nenter the door";
            c1.Labels.Add(new Rectangle(50, 500, (int)g.MeasureString(tuto1, c1.LabelFont).Width + 5, (int)g.MeasureString(tuto1, c1.LabelFont).Height));
            c1.Labels_Text.Add(tuto1);
            string tuto2 = "Click 'Space' to jump";
            c1.Labels.Add(new Rectangle(400, 350, (int)g.MeasureString(tuto2, c1.LabelFont).Width + 5, (int)g.MeasureString(tuto2, c1.LabelFont).Height));
            c1.Labels_Text.Add(tuto2);
            tutorial.Chambers.Add(c1);

            Chamber c2 = new Chamber(1, 0);
            c2.HitBoxes.Add(new Rectangle(0, 420, 600, h));
            c2.HitBoxes.Add(new Rectangle(0, 520, l, h));
            c2.HitBoxes.Add(new Rectangle(800, 420, 180, h));
            c2.HitBoxes.Add(new Rectangle(0, 0, 900, 150));
            c2.HitBoxes.Add(new Rectangle(960, 0, l, h));
            c2.GreenLiq.Add(new Rectangle(200, 420, 200, liqThns));
            c2.BlueLiq.Add(new Rectangle(620, 520, 150, liqThns));
            c2.Spikes.Add(new Rectangle(780, 500, spikesz, spikesz));
            c2.LabelFont = c1.LabelFont;
            string tuto3 = "Green liquid is sticky";
            c2.Labels.Add(new Rectangle(150, 300, (int)g.MeasureString(tuto3, c2.LabelFont).Width + 5, (int)g.MeasureString(tuto3, c2.LabelFont).Height));
            c2.Labels_Text.Add(tuto3);
            string tuto4 = "Blue liquid\n makes you bounce";
            c2.Labels.Add(new Rectangle(620, 440, (int)g.MeasureString(tuto4, c2.LabelFont).Width + 5, (int)g.MeasureString(tuto4, c2.LabelFont).Height));
            c2.Labels_Text.Add(tuto4);
            c2.Ladders.Add(new Rectangle(900, 0, 60, 420));
            tutorial.Chambers.Add(c2);

            Chamber c3 = new Chamber(1, 1);
            c3.HitBoxes.Add(new Rectangle(0, 520, 900, h));
            c3.HitBoxes.Add(new Rectangle(960, 520, l, h));
            c3.HitBoxes.Add(new Rectangle(0, 350, 100, h));
            c3.HitBoxes.Add(new Rectangle(250, 0, 100, 450));
            c3.HitBoxes.Add(new Rectangle(450, 485, 100, 15));
            c3.GreenLiq.Add(new Rectangle(80, 370, liqThns, 140));
            c3.GreenLiq.Add(new Rectangle(250, 20, liqThns, 410));
            c3.PurpleLiq.Add(new Rectangle(400, 520, 200, liqThns));
            c3.Spikes.Add(new Rectangle(660, 500, spikesz, spikesz));
            c3.Spikes.Add(new Rectangle(680, 500, spikesz, spikesz));
            c3.Spikes.Add(new Rectangle(700, 500, spikesz, spikesz));
            c3.LabelFont = c1.LabelFont;
            string tuto5 = "Purple spikes kill you";
            c3.Labels.Add(new Rectangle(650, 400, (int)g.MeasureString(tuto5, c3.LabelFont).Width + 5, (int)g.MeasureString(tuto5, c3.LabelFont).Height));
            c3.Labels_Text.Add(tuto5);
            string tuto6 = "Purple liquid damages\nyou over time";
            c3.Labels.Add(new Rectangle(400, 350, (int)g.MeasureString(tuto6, c3.LabelFont).Width + 5, (int)g.MeasureString(tuto6, c3.LabelFont).Height));
            c3.Labels_Text.Add(tuto6);
            string tuto7 = "Green liquid on walls makes you slide\n and make you wall jump by clicking space";
            c3.Labels.Add(new Rectangle(400, 200, (int)g.MeasureString(tuto7, c3.LabelFont).Width + 5, (int)g.MeasureString(tuto7, c3.LabelFont).Height));
            c3.Labels_Text.Add(tuto7);
            c3.Ladders.Add(new Rectangle(900, 490, 60, h));
            tutorial.Chambers.Add(c3);

            Chamber c4 = new Chamber(0, 1);
            c4.HitBoxes.Add(new Rectangle(900, 250, l, h));
            c4.HitBoxes.Add(new Rectangle(700, 550, 200, h));
            c4.HitBoxes.Add(new Rectangle(650, 220, 50, h));
            c4.HitBoxes.Add(new Rectangle(450, 550, 200, h));
            c4.HitBoxes.Add(new Rectangle(350, 220, 100, h));
            c4.HitBoxes.Add(new Rectangle(0, 0, 150, h));
            c4.HitBoxes.Add(new Rectangle(900, 175, 50, 50));
            c4.BlueLiq.Add(new Rectangle(700, 550, 180, liqThns));
            c4.Spikes.Add(new Rectangle(880, 530, spikesz, spikesz));
            c4.GreenLiq.Add(new Rectangle(900, 175, 50, liqThns));
            c4.GreenLiq.Add(new Rectangle(430, 230, liqThns, 320));
            c4.LabelFont = c1.LabelFont;
            string tuto8 = "The higher you fall from,\nthe higher the bounce on blue liquid";
            c4.Labels.Add(new Rectangle(700, 100, (int)g.MeasureString(tuto8, c4.LabelFont).Width + 5, (int)g.MeasureString(tuto8, c4.LabelFont).Height));
            c4.Labels_Text.Add(tuto8);
            string tuto9 = "you can go up walls with green liquid\n by clicking space and then\n the direction of the wall";
            c4.Labels.Add(new Rectangle(400, 100, (int)g.MeasureString(tuto9, c4.LabelFont).Width + 5, (int)g.MeasureString(tuto9, c4.LabelFont).Height));
            c4.Labels_Text.Add(tuto9);
            c4.Ladders.Add(new Rectangle(950, 175, 20, 75));
            tutorial.Chambers.Add(c4);
            //

            //Level 1
        }

        Player p1 = Form1.p1;
        float gravity = 0.2f;
        float friction = 1f;
        Chamber selectedChamber = new Chamber(0, 0);
        Level currentLevel;
        bool chamberLoaded = false;
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();

            #region Next Chamber
            if (p1.PosX > ClientSize.Width)
            {
                selectedChamber.X++;
                p1.PosX = 0;
                chamberLoaded = false;
            }
            if (p1.PosX < -10)
            {
                selectedChamber.X--;
                p1.PosX = ClientSize.Width;
                chamberLoaded = false;
            }
            if (p1.PosY < 0)
            {
                selectedChamber.Y++;
                p1.PosY = ClientSize.Height;
                chamberLoaded = false;
            }
            if (p1.PosY > ClientSize.Height + 10)
            {
                selectedChamber.Y--;
                p1.PosY = 0;
                chamberLoaded = false;
            }
            
            if (!chamberLoaded)
            {
                foreach (Chamber c in currentLevel.Chambers)
                {
                    if (c.X == selectedChamber.X && c.Y == selectedChamber.Y)
                    {
                        selectedChamber = new Chamber(c);
                    }
                }
                LoadChamber();
                chamberLoaded = true;
            }
            if(t % 80 == 0)
            {
                LoadChamber();
            }
            t++;
            #endregion

            g.FillRectangle(new SolidBrush(BackColor), p1.PosX, p1.PosY, 10, 10);

            #region Collisions
            //Blue liq
            foreach (Rectangle r in selectedChamber.BlueLiq)
            {
                if (r.IntersectsWith(new Rectangle((int)p1.PosX, (int)(p1.PosY + p1.SpeedY), 10, 10)) && PosXonRect(r))
                {
                    p1.PosY = r.Y - 10;
                    p1.SpeedY -= 4f/100f * p1.SpeedY;
                    p1.SpeedY = -p1.SpeedY;
                }
            }
            //hitboxes
            bool vincolated = false;
            foreach (Rectangle r in selectedChamber.HitBoxes)
            {
                if (CollisionTop(r, (int)p1.SpeedY))
                {
                    p1.SpeedY = 0;
                    //if (p1.SpeedX >= friction)
                    //{
                    //    p1.SpeedX -= friction;
                    //}
                    //else if (p1.SpeedX <= -friction)
                    //{
                    //    p1.SpeedX += friction;
                    //}
                    //else
                    //{
                    //    p1.SpeedX = 0;
                    //}
                    p1.PosY = r.Top - 10;
                    vincolated = true;
                }
                else if (CollisionTop(r, 0) && PosXonRect(r))
                {
                    //if (p1.SpeedX >= friction)
                    //{
                    //    p1.SpeedX -= friction;
                    //}
                    //else if (p1.SpeedX <= -friction)
                    //{
                    //    p1.SpeedX += friction;
                    //}
                    //else
                    //{
                    //    p1.SpeedX = 0;
                    //}
                    p1.PosY = r.Top - 10;
                    vincolated = true;
                }
                if (CollisionBottom(r, (int)p1.SpeedY))
                {
                    p1.SpeedY = 0;
                    p1.PosY = r.Bottom;
                }
                else if (CollisionBottom(r, 0) && PosXonRect(r))
                {
                    p1.PosY = r.Bottom;
                }
                if (CollisionLeft(r, (int)p1.SpeedX)) 
                {
                    p1.SpeedX = 0;
                    p1.PosX = r.Left - 11;
                }
                else if(CollisionRight(r, (int)p1.SpeedX))
                {
                    p1.SpeedX = 0;
                    p1.PosX = r.Right;
                }
            }
            if (!vincolated && !p1.InLadders)
            {
                p1.SpeedY += gravity;
            }
            //Gren liq
            foreach (Rectangle r in selectedChamber.GreenLiq)
            {
                if(CollisionRight(r, -3))
                {
                    p1.SpeedY = 1;
                    p1.GreenLiqCollision = 2;
                    break;
                }
                else if (CollisionLeft(r, 3))
                {
                    p1.SpeedY = 1;
                    p1.GreenLiqCollision = 1;
                    break;
                }
                else if (CollisionTop(r, 0) && PosXonRect(r))
                {
                    p1.GreenLiqCollision = 4;//0=null, 1=left, 2=right, 3=bottom, 4=top;
                    break;
                }
                else
                {
                    p1.GreenLiqCollision = 0;
                }
            }
            //Purple lq
            foreach (Rectangle r in selectedChamber.PurpleLiq)
            {
                if (CollisionTop(r, 0) && PosXonRect(r))
                {
                    p1.Health -= 2.5f;
                }
            }
            //Spikes
            foreach (Rectangle r in selectedChamber.Spikes)
            {
                if(r.IntersectsWith(new Rectangle((int)p1.PosX, (int)p1.PosY, 10, 10)))
                {
                    p1.Health = 0;
                }
            }
            //Ladders
            foreach (Rectangle r in selectedChamber.Ladders)
            {
                if (r.IntersectsWith(new Rectangle((int)p1.PosX, (int)p1.PosY, 10, 10)))
                {
                    p1.InLadders = true;
                }
                else
                {
                    p1.InLadders = false;
                }
            }
            #endregion
            if(p1.Health <= 0)
            {
                Death();
                return;
            }

            if(p1.SpeedY == 0)
            {
                p1.Jumps = 1;
            }

            p1.PosX += p1.SpeedX; p1.PosY += p1.SpeedY;

            g.FillRectangle(new SolidBrush(p1.Color), p1.PosX, p1.PosY, 10, 10);

            lbl_p1Health.Text = p1.Health.ToString();
        }

        private void Death()
        {
            selectedChamber = tutorial.Chambers[0];//last checkpoint in the level
            chamberLoaded = false;
            p1.PosX = 400;//last checkpoint in the level
            p1.PosY = 200;
            p1.Health = 100;
        }

        #region HitBoxes
        private bool CollisionLeft(Rectangle r, int pred)
        {
            return r.Contains((int)p1.PosX + 10 + pred, (int)p1.PosY) && r.Contains((int)p1.PosX + 10 + pred, (int)p1.PosY + 10);
        }
        private bool CollisionRight(Rectangle r, int pred)
        {
            return r.Contains((int)p1.PosX + pred, (int)p1.PosY) && r.Contains((int)p1.PosX + pred, (int)p1.PosY + 10);
        }
        private bool CollisionBottom(Rectangle r, int pred)
        {
            return r.Contains((int)p1.PosX, (int)(p1.PosY + pred)) || r.Contains((int)p1.PosX + 10, (int)(p1.PosY + pred));
        }
        private bool CollisionTop(Rectangle r, int pred)
        {
            return r.Contains((int)p1.PosX, (int)(p1.PosY + 10 + pred)) || r.Contains((int)p1.PosX + 10, (int)(p1.PosY + 10 + pred));
        }
        private bool PosXonRect(Rectangle r)
        {
            return r.Left <= p1.PosX + 10 && p1.PosX <= r.Right;
        }
        #endregion

        #region Keys
        private async void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                p1.SpeedX = 2;
            }
            if (e.KeyCode == Keys.A)
            {
                p1.SpeedX = -2;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (p1.InLadders)
                {
                    p1.SpeedY = -2;
                }
                else if (p1.GreenLiqCollision == 1)//0=null, 1=left, 2=right, 3=bottom, 4=top;
                {
                    p1.SpeedX = -4;
                    await Task.Delay(20);
                    p1.SpeedY = -6;
                    p1.Jumps = 0;
                    //foreach (Rectangle r in selectedChamber.HitBoxes)
                    //{
                    //    if (CollisionTop(r, (int)p1.SpeedY))
                    //    {
                    //        while (p1.SpeedX < 0)
                    //        {
                    //            p1.SpeedX += friction;
                    //            await Task.Delay(5);
                    //        }
                    //    }
                    //    else if (CollisionTop(r, 0) && PosXonRect(r))
                    //    {
                    //        while (p1.SpeedX < 0)
                    //        {
                    //            p1.SpeedX += friction;
                    //            await Task.Delay(5);
                    //        }
                    //    }
                    //}
                }
                else if (p1.GreenLiqCollision == 2)
                {
                    p1.SpeedX = 4;
                    await Task.Delay(20);
                    p1.SpeedY = -6;
                    p1.Jumps = 0;
                }
                else if(p1.GreenLiqCollision == 0 && p1.Jumps > 0)
                {
                    p1.SpeedY = -6;
                    p1.Jumps--;
                }
            }
            if(e.KeyCode == Keys.E)
            {
                //Doors
                int DoorNum = 0;
                for(int i = 0; i < selectedChamber.Doors.Count; i++)
                {
                    if (selectedChamber.Doors[i].IntersectsWith(new Rectangle((int)p1.PosX, (int)p1.PosY, 10, 10)))
                    {
                        DoorNum = i;
                    }
                }
                switch (DoorNum)
                {
                    case 0:
                        currentLevel = levels[1];
                        chamberLoaded = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void GamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                p1.SpeedX = 0;
            }
            if (e.KeyCode == Keys.A)
            {
                p1.SpeedX = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (p1.InLadders)
                {
                    p1.SpeedY = 0;
                }
            }
        }
        #endregion

        private void LoadChamber()
        {
            g = CreateGraphics();
            g.Clear(BackColor);
            foreach (Rectangle r in selectedChamber.HitBoxes)
            {
                g.FillRectangle(Brushes.Black, r);
            }
            foreach (Rectangle r in selectedChamber.Doors)
            {
                g.FillRectangle(Brushes.Brown, r);
            }
            foreach (Rectangle r in selectedChamber.Ladders)
            {
                g.FillRectangle(Brushes.SandyBrown, r);
            }
            foreach (Rectangle r in selectedChamber.GreenLiq)
            {
                g.FillRectangle(Brushes.Green, r);
            }
            foreach (Rectangle r in selectedChamber.BlueLiq)
            {
                g.FillRectangle(Brushes.Blue, r);
            }
            foreach (Rectangle r in selectedChamber.PurpleLiq)
            {
                g.FillRectangle(Brushes.Purple, r);
            }
            foreach (Rectangle r in selectedChamber.Spikes)
            {
                Point[] vertici = {new Point((r.X + r.X + r.Width) / 2, r.Y), new Point(r.X, r.Y + r.Height), new Point(r.X + r.Width, r.Y + r.Height)};
                g.FillPolygon(Brushes.Purple, vertici);
            }
            for (int i = 0; i < selectedChamber.Labels.Count; i++)
            {
                g.DrawRectangle(new Pen(Color.Black, 2), selectedChamber.Labels[i]);
                g.DrawString(selectedChamber.Labels_Text[i], selectedChamber.LabelFont, Brushes.Yellow, selectedChamber.Labels[i]);
            }
        }

        private void GamePlay_Resize(object sender, EventArgs e)
        {
            Width = 1016;
            Height = 639;
        }
    }
}
