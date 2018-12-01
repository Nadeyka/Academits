using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class KelvinToFahrenheitConverter : ITemperatureConverter
    {
        public double ConvertTemp(double degree)
        {
            double fahrenheitConst1 = 32;
            double kelvinConst = 273.15;
            return Math.Round((degree - kelvinConst) * 9 / 5 + fahrenheitConst1, 3);
        }
    }
}
