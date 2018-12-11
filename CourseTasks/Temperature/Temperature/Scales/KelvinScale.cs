using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class KelvinScale : IScale
    {
        public const double KelvinConst = 273.15;
        public string ScaleName
        {
            get { return "° Кельвина"; }
        }

        public double ConvertTempToCelsium(double degree)
        {
            return degree - KelvinConst;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree + KelvinConst;
        }

    }
}
