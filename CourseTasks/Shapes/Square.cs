using System;

namespace Shapes
{
    public class Square : Shape
    {
        public double Length { get; set; }

        private int edgesQuantity = 4;

        public Square(double length)
        {
            Length = length;
        }

        public override double GetArea()
        {
            return Math.Sqrt(Length);
        }

        public override double GetPerimeter()
        {
            return Length * edgesQuantity;
        }

        public override double GetHeight()
        {
            return Length;
        }

        public override double GetWidth()
        {
            return Length;
        }
    }
}
