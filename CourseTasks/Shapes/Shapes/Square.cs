using System;
using System.Text;

namespace Shapes.Shapes
{
    public class Square : IShape
    {
        public double Length { get; set; }

        private const int EdgesQuantity = 4;

        public Square(double length)
        {
            Length = length;
        }

        public double GetArea()
        {
            return Length * Length;
        }

        public double GetPerimeter()
        {
            return Length * EdgesQuantity;
        }

        public double GetHeight()
        {
            return Length;
        }

        public double GetWidth()
        {
            return Length;
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.AppendLine("Квадрат");
            sBuilder.AppendLine("Сторона = " + Length);
            return sBuilder.ToString();
        }

        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }
            if (ReferenceEquals(o, null) || o.GetType() != this.GetType())
            {
                return false;
            }
            Square square = (Square)o;
            return Length == square.Length;
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode();
        }
    }
}
