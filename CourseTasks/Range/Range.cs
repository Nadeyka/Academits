
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return (number <= To && number >= From);
        }

        public Range GetIntersect(Range r2)
        {
            if (To < r2.From || From > r2.To)
            {
                return null;
            }

            double maxElement = GetMax(To, r2.To);
            double minElement = GetMin(From, r2.From);
            double leftBorder = From != minElement ? From : r2.From;
            double rightBorder = To != maxElement ? To : r2.To;
            if (leftBorder != rightBorder)
            {
                return new Range(leftBorder, rightBorder);
            }
            return null;
        }

        private double GetMax(double number1, double number2)
        {
            double max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            return max;
        }

        private double GetMin(double number1, double number2)
        {
            double min = number1;
            if (number2 < min)
            {
                min = number2;
            }
            return min;
        }

        public Range[] GetUnion(Range r2)
        {
            if (To < r2.From || From > r2.To)
            {
                return new[] { new Range(From, To), new Range(r2.From, r2.To) };
            }

            double maxElement = GetMax(To, r2.To);
            double minElement = GetMin(From, r2.From);
            return new[] { new Range(minElement, maxElement) };
        }

        public Range[] GetDifference(Range r2)
        {
            if (To < r2.From || From > r2.To)
            {
                return new[] { new Range(From, To) };
            }
            if (From < r2.From && To <= r2.To)
            {
                return new[] { new Range(From, r2.From) };
            }
            if (From < r2.From && To > r2.To)
            {
                return new[] { new Range(From, r2.From), new Range(r2.To, To) };
            }
            if (From >= r2.From && To > r2.To)
            {
                return new[] { new Range(r2.To, To) };
            }
            return new Range[0];
        }
    }
}
