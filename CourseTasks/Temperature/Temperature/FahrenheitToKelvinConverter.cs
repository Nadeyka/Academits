using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class FahrenheitToKelvinConverter : ITemperatureConverter
    {
        public double ConvertTemp(double degree)
        {
            double fahrenheitConst1 = 32;
            double kelvinConst = 273.15;
            return Math.Round((degree - fahrenheitConst1) * 5 / 9 + kelvinConst, 3);
        }
    }
}
