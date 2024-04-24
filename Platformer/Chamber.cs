using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Chamber
    {
        public List<Rectangle> HitBoxes { get; set; } = new List<Rectangle>();
        public List<Rectangle> Doors { get; set; } = new List<Rectangle>();
        public List<Rectangle> Ladders { get; set; } = new List<Rectangle>();
        public List<Rectangle> GreenLiq { get; set; } = new List<Rectangle>();
        public List<Rectangle> BlueLiq { get; set; } = new List<Rectangle>();
        public List<Rectangle> Spikes { get; set; } = new List<Rectangle>();
        public List<Rectangle> PurpleLiq { get; set; } = new List<Rectangle>();
        public List<Rectangle> Labels { get; set; } = new List<Rectangle>();
        public List<string> Labels_Text { get; set; } = new List<string>();
        public Font LabelFont { get; set; }
        //public List<Image> TexturesOfHitBoxes { get; set; }
        //public List<Rectangle> Decorations { get; set; }
        //public List<Image> TexturesOfDecorations { get; set; }
        //public Image Background { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Chamber() {}
        public Chamber(Chamber c)
        {
            HitBoxes = c.HitBoxes;
            Doors = c.Doors;
            Ladders = c.Ladders;
            GreenLiq = c.GreenLiq;
            BlueLiq = c.BlueLiq;
            Spikes = c.Spikes;
            PurpleLiq = c.PurpleLiq;
            Labels = c.Labels;
            Labels_Text = c.Labels_Text;
            LabelFont = c.LabelFont;
            X = c.X;
            Y = c.Y;
        }
        public Chamber(int x,  int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X}; {Y}";
        }
    }
}
