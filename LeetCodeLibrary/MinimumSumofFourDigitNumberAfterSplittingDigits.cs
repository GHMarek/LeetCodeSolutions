using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumSumofFourDigitNumberAfterSplittingDigits
    {
        public int MinimumSum(int num)
        {

            var z = num.ToString().ToList();

            z.Sort();

            var new1 = Int32.Parse($@"{Convert.ToString(z[0])}{Convert.ToString(z[2])}");
            var new2 = Int32.Parse($@"{Convert.ToString(z[1])}{Convert.ToString(z[3])}");

            return new1 + new2;
        
        }
    }
}
