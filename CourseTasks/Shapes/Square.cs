using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder("Квадрат\n");
            sBuilder.Append("Площадь: " + GetArea() + "\n");
            sBuilder.Append("Периметр: " + GetPerimeter() + "\n");
            sBuilder.Append("Ширина: " + GetWidth() + "\n");
            sBuilder.Append("Высота: " + GetHeight() + "\n");
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
            int prime = 37;
            int hash = 1;
            hash = prime * hash + Length.GetHashCode();
            return hash;
        }

    }
}
