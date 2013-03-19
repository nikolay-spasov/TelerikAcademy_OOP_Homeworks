using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return string.Format("Rectangle({0}, {1})", Width, Height);
        }
    }
}
