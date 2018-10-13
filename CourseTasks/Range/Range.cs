
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
            Range intersectRange = new Range(From, To);
            if (To < r2.From || From > r2.To)
            {
                return null;
            }

            double[] rangeBorders = { From, To, r2.From, r2.To };
            double maxElement = GetMax(rangeBorders);
            double minElement = GetMin(rangeBorders);
            double[] borders = {minElement, maxElement};

            foreach (double e in rangeBorders)
            {
                if (e != minElement && e != maxElement)
                {
                    if (borders[0] == minElement)
                    {
                        borders[0] = e;
                    }
                    else
                    {
                        borders[1] = e;
                    }
                }
            }
            if (borders[0] < borders[1])
            {
               intersectRange.From = borders[0];
               intersectRange.To = borders[1];
            }
            else
            {
                intersectRange.From = borders[1];
                intersectRange.To = borders[0];
            }
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
                if (e < min)
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
        }

        public Range[] GetDifference(Range r2)
        {
            if (To < r2.From)
            {
                Range[] differenceRangeArray = { this };
                return differenceRangeArray;
            }
            else if (To >= r2.From && From <= r2.From)
            {
                Range[] differenceRangeArray = { new Range(From, r2.From) };
                return differenceRangeArray;
            }
            else if (From <= r2.From && To >= r2.To)
            {
                Range[] differenceRangeArray = { new Range(From, r2.From), new Range(r2.To, To) };
                return differenceRangeArray;
            }
            else if (From >= r2.From && To >= r2.To)
            {
                Range[] differenceRangeArray = { new Range(r2.To, To) };
                return differenceRangeArray;
            }
            else //(From >= r2.From && To <= r2.To)
            {
                return null;
            }

            //return differenceRangeArray;
        }

    }
}
