using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Width cannot be negative");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Height cannot be negative");
                }
                this.height = value;
            }
        }
    }
}
