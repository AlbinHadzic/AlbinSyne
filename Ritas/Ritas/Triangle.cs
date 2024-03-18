using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritas
{
    internal class Triangle : Shape
    {
        public override void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(Color))
            {
                Point[] points = new Point[3];
                points[0] = new Point(Position.X, Position.Y - Size); // Top point
                points[1] = new Point(Position.X - Size, Position.Y + Size); // Bottom left point
                points[2] = new Point(Position.X + Size, Position.Y + Size); // Bottom right point

                g.FillPolygon(brush, points);
            }
        }
    }
}
