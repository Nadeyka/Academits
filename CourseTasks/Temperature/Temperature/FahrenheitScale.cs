using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class FahrenheitScale : ITemperatureConverter
    {
        double fahrenheitConst = 32;

        public double ConvertTempToCelsium(double degree)
        {
            return Math.Round((degree - fahrenheitConst) * 5 / 9, 3);
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return Math.Round(degree * 9 / 5 + fahrenheitConst, 3);
        }

    }
}
