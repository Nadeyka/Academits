using System;

namespace Range
{
    class Program
    {
        static void Main()
        {
            Range range = new Range(-0.1, 25);
            double length = range.GetLength();
            Console.WriteLine("Длина интервала: " + length);
            double number = -2.6;
            bool isInInterval = range.IsInside(number);
            if (isInInterval)
            {
                Console.WriteLine("Число {0} входит в интервал {1} - {2}", number, range.From, range.To);
            }
            else
            {
                Console.WriteLine("Число {0} не входит в интервал {1} - {2}", number, range.From, range.To);
            }
        }
    }
}
