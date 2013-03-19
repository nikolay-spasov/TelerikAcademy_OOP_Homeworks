using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Circle : Shape
    {
        public Circle(double diameter) : base(diameter, diameter) { }

        public override double CalculateSurface()
        {
            double radius = Width / 2;
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return string.Format("Circle({0})", Width);
        }
    }
}
