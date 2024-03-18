using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritas
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public override void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(Color))
            {
                int adjustedX = Position.X - Size / 2; // The Width of the rectangle
                int adjustedY = Position.Y - Height / 2; // The Height of the rectangle
                g.FillRectangle(brush, adjustedX, adjustedY, Size, Height);
            }
        }
    }
}
