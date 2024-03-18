using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritas
{
    public class Circle : Shape
    {

        public override void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(Color))
            {
                int adjustedX = Position.X - Size / 2;
                int adjustedY = Position.Y - Size / 2;
                g.FillEllipse(brush, Position.X, Position.Y, Size, Size);
            }
        }
    }
}
