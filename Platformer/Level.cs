using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Level
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Chamber> Chambers { get; set; }
        public List<Rectangle> Keys { get; set; }
        public Level() 
        {
            Chambers = new List<Chamber>();
        }
    }
}
