using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConvertTheTemperature
    {
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15, celsius * 1.8 + 32.00 };
        }
    }
}
