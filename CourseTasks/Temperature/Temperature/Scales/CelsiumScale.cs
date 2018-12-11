using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public class CelsiumScale : IScale
    {
        public string ScaleName
        {
            get { return "° Цельсия"; }
        }

        public double ConvertTempToCelsium(double degree)
        {
            return degree;
        }

        public double ConvertTempFromCelsium(double degree)
        {
            return degree;
        }
    }
}
