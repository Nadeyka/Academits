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

        public double CalcIntervalLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            bool isInside = false;
            if (number <= To && number >= From)
            {
                isInside = true;
            }
            return isInside;
        }
    }
}
