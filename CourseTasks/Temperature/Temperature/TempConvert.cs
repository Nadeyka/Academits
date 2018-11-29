using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class TempConvert
    {
        public virtual double ConvertTemp(double degree)
        {
            return degree;
        }
    }

    public class CelsiumToKelvin : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double kelvinConst = 273.15;
            return degree + kelvinConst;
        }
    }

    public class KelvinToCelsium : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double kelvinConst = 273.15;
            return degree - kelvinConst;
        }
    }

    public class CelsiumToFarengeit : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double farengeitConst1 = 32;
            return Math.Round(degree * 9 / 5 + farengeitConst1, 3);
        }
    }

    public class FarengeitToCelsium : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double farengeitConst1 = 32;
            return Math.Round((degree - farengeitConst1) * 5 / 9, 3);
        }
    }

    public class FarengeitToKelvin : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double farengeitConst1 = 32;
            double kelvinConst = 273.15;
            return Math.Round((degree - farengeitConst1) * 5 / 9 + kelvinConst, 3);
        }
    }

    public class KelvinToFarengeit : TempConvert
    {
        public override double ConvertTemp(double degree)
        {
            double farengeitConst1 = 32;
            double kelvinConst = 273.15;
            return Math.Round((degree - kelvinConst) * 9 / 5 + farengeitConst1, 3);
        }
    }

    //public static double ConvertCelsiumToKelvin(double degree)
    //{
    //    double kelvinConst = 273.15;
    //    return degree + kelvinConst;
    //}

    //public static double ConvertKelvinToCelsium(double degree)
    //{
    //    double kelvinConst = 273.15;
    //    return degree - kelvinConst;
    //}
    //public static double ConvertCelsiumToFarengeit(double degree)
    //{
    //    double farengeitConst1 = 32;
    //    return Math.Round(degree * 9 / 5 + farengeitConst1, 3);
    //}

    //public static double ConvertFarengeitToCelsium(double degree)
    //{
    //    double farengeitConst1 = 32;
    //    return Math.Round((degree - farengeitConst1) * 5 / 9, 3);
    //}
    //public static double ConvertFarengeitToKelvin(double degree)
    //{
    //    double farengeitConst1 = 32;
    //    double kelvinConst = 273.15;
    //    return Math.Round((degree - farengeitConst1) * 5 / 9 + kelvinConst, 3);
    //}

    //public static double ConvertKelvinToFarengeit(double degree)
    //{
    //    double farengeitConst1 = 32;
    //    double kelvinConst = 273.15;
    //    return Math.Round((degree - kelvinConst) * 9 / 5 + farengeitConst1, 3);
    //}
    //}
}
