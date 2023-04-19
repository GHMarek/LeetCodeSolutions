using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindThePivotInteger
    {
        public int PivotInteger(int n)
        {

            int rightSum = n * (n + 1) / 2;
            int leftSum = 0;

            if (n == 1)
            {
                return 1;
            }

            for (int i = 1; i < n; i++)
            {
                leftSum += i;

                if (leftSum == rightSum)
                {
                    return i;
                }

                rightSum -= i;
            }
            
            return -1;
        }
    }
}
