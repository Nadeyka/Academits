using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class KelvinScale : IScale
    {
        public const double kelvinConst = 273.15;
        //public const string scaleName = "° Кельвина";

        public double ConvertTempToCelsium(double degree)
        {
            return degree - kelvinConst;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree + kelvinConst;
        }

    }
}
