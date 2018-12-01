using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class FahrenheitToCelsiumConverter : ITemperatureConverter
    {
        public double ConvertTemp(double degree)
        {
            double fahrenheitConst1 = 32;
            return Math.Round((degree - fahrenheitConst1) * 5 / 9, 3);
        }
    }
}
