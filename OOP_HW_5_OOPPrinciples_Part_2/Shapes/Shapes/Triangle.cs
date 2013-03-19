using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return Width * Height / 2d;
        }

        public override string ToString()
        {
            return string.Format("Triangle({0}, {1})", Width, Height);
        }
    }
}
