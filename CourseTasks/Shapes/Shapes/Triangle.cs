using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
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
            double side1 = GetSideLength(X1, Y1, X2, Y2);
            double side2 = GetSideLength(X1, Y1, X3, Y3);
            double side3 = GetSideLength(X2, Y2, X3, Y3);
            return side1 + side2 + side3;
        }

        private static double GetMax(double[] vertex)
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

        private static double GetMin(double[] vertex)
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

        private static double GetSideLength(double topX1, double topY1, double topX2, double topY2)
        {
            return Math.Sqrt(Math.Pow(topX2 - topX1, 2) + Math.Pow(topY2 - topY1, 2));
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.AppendLine("Треугольник");
            sBuilder.AppendLine("Вершина 1: X1 = " + X1 + " Y1 = " + Y1);
            sBuilder.AppendLine("Вершина 2: X2 = " + X2 + " Y2 = " + Y2);
            sBuilder.AppendLine("Вершина 3: X3 = " + X3 + " Y3 = " + Y3);
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
            Triangle triangle = (Triangle)o;
            return X1 == triangle.X1 && X2 == triangle.X2 && X3 == triangle.X3 && Y1 == triangle.Y1 && Y2 == triangle.Y2 && Y3 == triangle.Y3;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;
            hash = prime * hash + X1.GetHashCode();
            hash = prime * hash + X2.GetHashCode();
            hash = prime * hash + X3.GetHashCode();
            hash = prime * hash + Y1.GetHashCode();
            hash = prime * hash + Y2.GetHashCode();
            hash = prime * hash + Y3.GetHashCode();
            return hash;
        }
    }
}
