using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public interface ITemperatureConverter
    {
        double ConvertTemp(double degree);
    }
}
