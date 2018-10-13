
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
            //Range intersectRange = new Range(From, To);
            if (To < r2.From || From > r2.To)
            {
                return null;
            }

            double[] rangeBorders = { From, To, r2.From, r2.To };
            double maxElement = GetMax(rangeBorders);
            double minElement = GetMin(rangeBorders);
            double[] borders = new double[2];

            for (int i = 0; i < rangeBorders.Length; ++i)
            {
                if (rangeBorders[i] != minElement && rangeBorders[i] != maxElement)
                {
                    rangeBorders.;
                }
            }
            if (borders[0] < borders[1])
            {
                Range intersectRange = new Range(borders[0], borders[1]);
            }
            else
            {
                Range intersectRange = new Range(borders[1], borders[0]);

            }
            //if (To >= r2.From && From <= r2.From)
            //{
            //    intersectRange.From = r2.From;
            //    intersectRange.To = To;
            //}
            //if (From >= r2.From && To <= r2.To)
            //{
            //    intersectRange.From = From;
            //    intersectRange.To = To;
            //}
            //if (From <= r2.From && To >= r2.To)
            //{
            //    intersectRange.From = r2.From;
            //    intersectRange.To = r2.To;
            //}
            //if (From >= r2.From && To >= r2.To)
            //{
            //    intersectRange.From = From;
            //    intersectRange.To = r2.To;
            //}
            return intersectRange;
        }

        private double GetMax(double[] rangeBorders)
        {
            double max = rangeBorders[0];
            foreach (double e in rangeBorders)
            {
                if (e > max)
                {
                    max = e;
                }
            }
            return max;
        }

        private double GetMin(double[] rangeBorders)
        {
            double min = rangeBorders[0];
            foreach (double e in rangeBorders)
            {
                if (e > min)
                {
                    min = e;
                }
            }
            return min;
        }

        public Range[] GetUnion(Range r2)
        {

            if (To < r2.From || From > r2.To)
            {
                Range[] unionRangeArray = { this, r2 };
                return unionRangeArray;
            }
            else
            {
                double[] rangeBorders = { From, To, r2.From, r2.To };
                double maxElement = GetMax(rangeBorders);
                double minElement = GetMin(rangeBorders);

                Range[] unionRangeArray = { new Range(minElement, maxElement) };
                return unionRangeArray;
            }

            //////////////////////////////////
            //Range[] unionRangeArray = new Range[2];
            //unionRangeArray[0] = r1;
            //// Range unionRange = new Range(r1.From, r1.To);
            //if (r1.To < r2.From)
            //{
            //    unionRangeArray[0] = r1;
            //    unionRangeArray[1] = r2;
            //}
            //if (r1.To >= r2.From && r1.From <= r2.From)
            //{
            //    unionRangeArray[0].From = r1.From;
            //    unionRangeArray[0].To = r2.To;
            //}
            //if (r1.From >= r2.From && r1.To <= r2.To)
            //{
            //    unionRangeArray[0].From = r2.From;
            //    unionRangeArray[0].To = r2.To;
            //}
            //if (r1.From <= r2.From && r1.To >= r2.To)
            //{
            //    unionRangeArray[0].From = r1.From;
            //    unionRangeArray[0].To = r1.To;
            //}
            //if (r1.From >= r2.From && r1.To >= r2.To)
            //{
            //    unionRangeArray[0].From = r2.From;
            //    unionRangeArray[0].To = r1.To;
            //}
            //return unionRangeArray;
        }

        public Range[] GetDifference(Range r2)
        {
            //Range[] differenceRangeArray = new Range[2];
            //differenceRangeArray[0] = r1;
            if (To < r2.From)
            {
                Range[] differenceRangeArray = { this };
                return differenceRangeArray;
                //differenceRangeArray[0] = r1;
            }
            if (To >= r2.From && From <= r2.From)
            {
                Range[] differenceRangeArray = { new Range(From, r2.From) };
                return differenceRangeArray;
                //differenceRangeArray[0].From = r1.From;
                //differenceRangeArray[0].To = r2.From;
            }
            if (From >= r2.From && To <= r2.To)
            {
                return null;
            }
            if (From <= r2.From && To >= r2.To)
            {
                Range[] differenceRangeArray = { new Range(From, r2.From), new Range(r2.To, To) };
                return differenceRangeArray;
                //differenceRangeArray[0].From = r1.From;
                //differenceRangeArray[0].To = r2.From;
                //differenceRangeArray[1].From = r2.To;
                //differenceRangeArray[1].To = r1.To;
            }
            if (From >= r2.From && To >= r2.To)
            {
                Range[] differenceRangeArray = { new Range(r2.To, To) };
                return differenceRangeArray;

                //differenceRangeArray[0].From = r2.To;
                //differenceRangeArray[0].To = r1.To;
            }
            //return differenceRangeArray;
        }

    }
}
