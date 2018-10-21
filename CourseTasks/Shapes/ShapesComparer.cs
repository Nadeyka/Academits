using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesComparer : IComparer<double>
    {
        public int Compare(double x1, double x2)
        {
            if (x1 > x2)
            {
                return 1;
            }
            if (x1 < x2)
            {
                return -1;
            }
            return 0;
        }
    }
}
