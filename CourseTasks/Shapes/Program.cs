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

            AreaComparator areaComparator = new AreaComparator();
            IShape maxArea = SearchMaxAreaShape(shapesList, areaComparator);
            Console.WriteLine("Фигура с максимальной площадью:");
            Console.WriteLine(maxArea.ToString());

            PerimeterComparator perimeterComparator = new PerimeterComparator();
            IShape secondPerimeter = SearchSecondPerimeterShape(shapesList, perimeterComparator);
            Console.WriteLine("Фигура со вторым по величине периметром:");
            Console.WriteLine(secondPerimeter.ToString());
        }

        public static IShape SearchMaxAreaShape(List<IShape> list, AreaComparator areaComparator)
        {
            Array.Sort(list.ToArray(), areaComparator);
            return list[list.Count - 1];
        }

        public static IShape SearchSecondPerimeterShape(List<IShape> list, PerimeterComparator perimeterComparator)
        {
            Array.Sort(list.ToArray(), perimeterComparator);
            return list[list.Count - 2];
        }

    }
}
