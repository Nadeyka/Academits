using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public static class TemperatureConverter
    {
        public static double ConvertTemperature(IScale fromTemp, IScale toTemp, double temperatureValue)
        {

            return toTemp.ConvertTempFromCelsium(fromTemp.ConvertTempToCelsium(temperatureValue));
        }
    }
}
