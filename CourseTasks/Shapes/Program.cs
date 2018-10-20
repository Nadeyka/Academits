using System;
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
            List<IShape> shapesList = new List<IShape>();
            shapesList.Add(new Square(20));
            shapesList.Add(new Rectangle(10,40));
            shapesList.Add(new Circle(30));
            shapesList.Add(new Triangle(0,0,10,0,5,10));
            shapesList.Add(new Square(25.1));
            shapesList.Add(new Square(61));
            shapesList.Add(new Rectangle(10.5, 14));
            shapesList.Add(new Circle(3.9));
            shapesList.Add(new Triangle(50, 0, 100, 100, 85, 150));

        }

        public IShape FindMaxArea(List<IShape> list)
        {
            list.Sort();
            return list[0];
        }
    }
}
