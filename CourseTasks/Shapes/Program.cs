using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapesList = new List<IShape>
            {
                new Square(20),
                new Rectangle(10, 40),
                new Circle(30),
                new Triangle(0, 0, 10, 0, 5, 10),
                new Square(25.1),
                new Square(61),
                new Rectangle(10.5, 14),
                new Circle(3.9),
                new Triangle(50, 0, 100, 100, 85, 150)
            };

            ShapesComparer cShape = new ShapesComparer();
            double maxArea = FindMaxArea(shapesList, cShape);
        }

        public static double FindMaxArea(List<IShape> list, ShapesComparer cShape)
        {
            double[] areaArray = new double[list.Count];

            for (int i = 0; i < list.Count; ++i)
            {
                areaArray[i] = list[i].GetArea();
            }
            Array.Sort(areaArray, cShape);
            return areaArray[list.Count - 1];
        }
    }
}
