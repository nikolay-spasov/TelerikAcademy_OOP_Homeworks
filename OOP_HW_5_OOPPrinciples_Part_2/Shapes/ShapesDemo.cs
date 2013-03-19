using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Shapes
{
    class ShapesDemo
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 10),
                new Circle(5),
                new Triangle(4, 10)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} surface = {1}", shape, shape.CalculateSurface());
            }
        }
    }
}
