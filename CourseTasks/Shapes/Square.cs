using System;

namespace Shapes
{
    public class Square : IShape
    {
        public double Length { get; set; }

        private int edgesQuantity = 4;

        public Square(double length)
        {
            Length = length;
        }

        public double GetArea()
        {
            return Math.Sqrt(Length);
        }

        public double GetPerimeter()
        {
            return Length * edgesQuantity;
        }

        public double GetHeight()
        {
            return Length;
        }

        public double GetWidth()
        {
            return Length;
        }
    }
}
