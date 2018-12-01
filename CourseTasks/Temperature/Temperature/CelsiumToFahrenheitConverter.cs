using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class CelsiumToFahrenheitConverter : ITemperatureConverter
    {
        public double ConvertTemp(double degree)
        {
            double fahrenheitConst1 = 32;
            return Math.Round(degree * 9 / 5 + fahrenheitConst1, 3);
        }
    }
}
