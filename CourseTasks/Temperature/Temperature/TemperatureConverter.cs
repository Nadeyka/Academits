using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public static class TemperatureConverter
    {
        public static double ConvertTemperature(IScale[] scaleList, IScale fromTemp, IScale toTemp, string selectedFromScale, string selectedToScale, double temperatureValue)
        {
            foreach (IScale eScale in scaleList)
            {
                if (eScale.ScaleName == selectedFromScale)
                {
                    fromTemp = eScale;
                }
                else if (eScale.ScaleName == selectedToScale)
                {
                    toTemp = eScale;
                }
            }

            return toTemp.ConvertTempFromCelsium(fromTemp.ConvertTempToCelsium(temperatureValue));
        }
    }
}
