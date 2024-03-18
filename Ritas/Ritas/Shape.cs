using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritas
{
    public abstract class Shape()
    {
        public enum ShapeType { Circle, Triangle, Square }
        public ShapeType Type { get; set; }
        public Point Position { get; set; }
        public Color Color { get; set; }
        public int Size { get; set; }

        public abstract void Draw(Graphics g);
    }
    
}
