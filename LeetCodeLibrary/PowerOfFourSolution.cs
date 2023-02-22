using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class PowerOfFourSolution
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n == 0)
                return false;
            while (n != 1)
            {
                if (n % 4 != 0)
                    return false;
                n = n / 4;
            }
            return true;
        }
    }
}

