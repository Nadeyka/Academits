using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetWidth()
        {
            return Radius * 2;
        }

        public double GetHeight()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Math.PI * Math.Sqrt(Radius);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder("Окружность\n");
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
            Circle circle = (Circle)o;
            return Radius == circle.Radius;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;
            hash = prime * hash + Radius.GetHashCode();
            return hash;
        }

    }
}
