﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public interface IScale
    {
        string scaleName { get; set; }
        double ConvertTempToCelsium(double degree);
        double ConvertTempFromCelsium(double degree);
    }
}
