using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Comparators;
using Shapes.Shapes;

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

            AreaComparator cShape = new AreaComparator();
            double maxArea = FindMaxArea(shapesList, cShape);
            Console.WriteLine("Максимальная площадь: " + maxArea);

            double secondPerimeter = FindSecondPerimeter(shapesList, cShape);
            Console.WriteLine("Второй по величине периметр: " + secondPerimeter);
            //Console.WriteLine((shapesList[3].ToString()));
        }

        public static double FindMaxArea(List<IShape> list, AreaComparator cShape)
        {
            Array.Sort(list.ToArray(), cShape);
            //return areaArray[list.Count - 1];
        }

        public static double FindSecondPerimeter(List<IShape> list, AreaComparator cShape)
        {
            double[] perimeterArray = new double[list.Count];

            for (int i = 0; i < list.Count; ++i)
            {
                perimeterArray[i] = list[i].GetPerimeter();
            }
            Array.Sort(perimeterArray, cShape);
            return perimeterArray[1];
        }

    }
}
