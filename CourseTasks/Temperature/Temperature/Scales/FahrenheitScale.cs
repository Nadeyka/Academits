using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class FahrenheitScale : IScale
    {
        public const double fahrenheitConst = 32;
        public string scaleName { get; set; }

        public FahrenheitScale()
        {
            scaleName = "° Фаренгейта";
        }

        public double ConvertTempToCelsium(double degree)
        {
            return (degree - fahrenheitConst) * 5 / 9;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree * 9 / 5 + fahrenheitConst;
        }
    }
}
