using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConApp
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            int y = 0;
            int z = x;
            int r;

            while (x > 0)
            {
                r = x % 10;
                x = x / 10;
                y = (10 * y) + r;

            }

            return y == z;
            
        }
    }
}
