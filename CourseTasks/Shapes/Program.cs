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
            IShape maxArea = FindMaxArea(shapesList, cShape);
            Console.WriteLine("Фигура с максимальной площадью:");
            Console.WriteLine(maxArea.ToString());

            IShape secondPerimeter = FindSecondPerimeter(shapesList, cShape);
            Console.WriteLine("Фигура со вторым по величине периметром:");
            Console.WriteLine(secondPerimeter.ToString());
        }

        public static IShape FindMaxArea(List<IShape> list, AreaComparator cShape)
        {
            Array.Sort(list.ToArray(), cShape);
            return list[list.Count - 1];
        }

        public static IShape FindSecondPerimeter(List<IShape> list, AreaComparator cShape)
        {
            Array.Sort(list.ToArray(), cShape);
            return list[list.Count - 2];
        }

    }
}
