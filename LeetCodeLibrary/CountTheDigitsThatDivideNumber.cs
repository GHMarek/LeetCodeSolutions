using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountTheDigitsThatDivideNumber
    {
        public int CountDigits(int num)
        {

            int res = 0;

            foreach (var i in num.ToString().ToArray())
            {
                if(num % Int32.Parse(Convert.ToString(i)) == 0)
                {
                    res++;
                }
            }
            

            return res;
        }
    }
}

