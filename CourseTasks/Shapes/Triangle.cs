using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : IShape
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public double GetWidth()
        {
            double[] vertex = { X1, X2, X3 };
            return GetMax(vertex) - GetMin(vertex);
        }

        public double GetHeight()
        {
            double[] vertex = { Y1, Y2, Y3 };
            return GetMax(vertex) - GetMin(vertex);
        }

        public double GetArea()
        {
            return Math.Abs((X1 - X3) * (Y2 - Y3) - (X2 - X3) * (Y1 - Y3)) / 2;
        }

        public double GetPerimeter()
        {
            double side1 = Math.Sqrt(Math.Abs(Math.Pow(X2 - X1, 2) - Math.Pow(Y2 - Y1, 2)));
            double side2 = Math.Sqrt(Math.Abs(Math.Pow(X3 - X1, 2) - Math.Pow(Y3 - Y1, 2)));
            double side3 = Math.Sqrt(Math.Abs(Math.Pow(X3 - X2, 2) - Math.Pow(Y3 - Y2, 2)));
            return side1 + side2 + side3;
        }

        private double GetMax(double[] vertex)
        {
            double max = vertex[0];
            foreach (double e in vertex)
            {
                if (e > max)
                {
                    max = e;
                }
            }
            return max;
        }

        private double GetMin(double[] vertex)
        {
            double min = vertex[0];
            foreach (double e in vertex)
            {
                if (e < min)
                {
                    min = e;
                }
            }
            return min;
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder("Треугольник\n");
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
            Triangle t = (Triangle)o;
            return X1 == t.X1 && X2 == t.X2 && X3 == t.X3 && Y1 == t.Y1 && Y2 == t.Y2 && Y3 == t.Y3;
        }

        public override int GetHashCode()
        {

        }
    }
}
