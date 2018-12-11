using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class FahrenheitScale : IScale
    {
        public const double FahrenheitConst = 32;
        public string ScaleName
        {
            get { return "° Фаренгейта"; }
        }

        public double ConvertTempToCelsium(double degree)
        {
            return (degree - FahrenheitConst) * 5 / 9;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree * 9 / 5 + FahrenheitConst;
        }
    }
}
