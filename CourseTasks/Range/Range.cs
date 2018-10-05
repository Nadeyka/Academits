
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

        public static Range GetIntersect(Range r1, Range r2)
        {
            Range intersectRange = new Range(r1.From, r1.To);
            if (r1.To < r2.From)
            {
                return null;
            }
            if (r1.To >= r2.From && r1.From <= r2.From)
            {
                intersectRange.From = r2.From;
                intersectRange.To = r1.To;
            }
            if (r1.From >= r2.From && r1.To <= r2.To)
            {
                intersectRange.From = r1.From;
                intersectRange.To = r1.To;
            }
            if (r1.From <= r2.From && r1.To >= r2.To)
            {
                intersectRange.From = r2.From;
                intersectRange.To = r2.To;
            }
            if (r1.From >= r2.From && r1.To >= r2.To)
            {
                intersectRange.From = r1.From;
                intersectRange.To = r2.To;
            }
            return intersectRange;
        }

        public static Range[] GetUnion(Range r1, Range r2)
        {
            Range[] unionRangeArray = new Range[2];
            unionRangeArray[0] = r1;
            // Range unionRange = new Range(r1.From, r1.To);
            if (r1.To < r2.From)
            {
                unionRangeArray[0] = r1;
                unionRangeArray[1] = r2;
            }
            if (r1.To >= r2.From && r1.From <= r2.From)
            {
                unionRangeArray[0].From = r1.From;
                unionRangeArray[0].To = r2.To;
            }
            if (r1.From >= r2.From && r1.To <= r2.To)
            {
                unionRangeArray[0].From = r2.From;
                unionRangeArray[0].To = r2.To;
            }
            if (r1.From <= r2.From && r1.To >= r2.To)
            {
                unionRangeArray[0].From = r1.From;
                unionRangeArray[0].To = r1.To;
            }
            if (r1.From >= r2.From && r1.To >= r2.To)
            {
                unionRangeArray[0].From = r2.From;
                unionRangeArray[0].To = r1.To;
            }
            return unionRangeArray;
        }

        public static Range[] GetDifference(Range r1, Range r2)
        {
            Range[] differenceRangeArray = new Range[2];
            differenceRangeArray[0] = r1;
            if (r1.To < r2.From)
            {
                differenceRangeArray[0] = r1;
            }
            if (r1.To >= r2.From && r1.From <= r2.From)
            {
                differenceRangeArray[0].From = r1.From;
                differenceRangeArray[0].To = r2.From - 0.001;
            }
            if (r1.From >= r2.From && r1.To <= r2.To)
            {
                differenceRangeArray[0] = null;
            }
            if (r1.From <= r2.From && r1.To >= r2.To)
            {
                differenceRangeArray[0].From = r1.From;
                differenceRangeArray[0].To = r2.From - 0.001;
                differenceRangeArray[1].From = r2.To + 0.001;
                differenceRangeArray[1].To = r1.To;
            }
            if (r1.From >= r2.From && r1.To >= r2.To)
            {
                differenceRangeArray[0].From = r2.To + 0.001;
                differenceRangeArray[0].To = r1.To;
            }
            return differenceRangeArray;
        }

    }
}
