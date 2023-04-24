using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfCommonFactors
    {
        public int CommonFactors(int a, int b)
        {
            int res = 1;

            for (int i = 2; i <= Math.Max(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    res++;
                }
            }

            return res;
        }

    }
}
