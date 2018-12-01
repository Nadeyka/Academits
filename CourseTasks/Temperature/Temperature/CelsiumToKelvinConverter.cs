using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class CelsiumToKelvinConverter : ITemperatureConverter
    {
        public double ConvertTemp(double degree)
        {
            double kelvinConst = 273.15;
            return degree + kelvinConst;
        }
    }
}
