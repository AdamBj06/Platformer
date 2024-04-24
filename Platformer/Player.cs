using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Player
    {
        public Color Color { get; set; } = Color.Red;
        public float Health { get; set; } = 100;
        public float PosX { get; set; } = 400;
        public float PosY { get; set; } = 200;
        public float SpeedX { get; set; } = 0;
        public float SpeedY { get; set; } = 0;
        public bool InLadders { get; set; } = false;
        public int GreenLiqCollision { get; set; } = 0;//0=null, 1=left, 2=right, 3=bottom, 4=top;
        public int Jumps { get; set; } = 1;
    }
}
