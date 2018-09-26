using System;
using System.Collections.Generic;
using System.Text;

namespace WeightConversionDLL
{
    public static class ConverterClass
    {
        public static double ConvertToGram(double ounces)
        {
            return ounces * 28.34952;
        }

        public static double ConvertToOunces(double gram)
        {
            return gram * 0.03527396195;
        }
    }
}
