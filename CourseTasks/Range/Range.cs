
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
            if (To <= r2.From || From >= r2.To)
            {
                return null;
            }
            return new Range(Math.Max(From, r2.From), Math.Min(To, r2.To));
        }

        public Range[] GetUnion(Range r2)
        {
            if (To < r2.From || From > r2.To)
            {
                return new[] { new Range(From, To), new Range(r2.From, r2.To) };
            }

            double[] arrayD = { From, To, r2.From, r2.To };
            return new[] { new Range(arrayD.Min(), arrayD.Max()) };
        }

        public Range[] GetDifference(Range r2)
        {
            if (To <= r2.From || From >= r2.To)
            {
                return new[] { new Range(From, To) };
            }
            if (From < r2.From && To < r2.To)
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
