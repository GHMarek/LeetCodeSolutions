using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumSumWithExactlyKElements
    {
        public int MaximizeSum(int[] nums, int k)
        {
            //int res = 0;
            //int localMax = nums.Max();

            //for (int i = 0; i < k; i++)
            //{
            //    res += localMax + i;
            //}

            //return res;

            return Enumerable.Range(0, k).Sum() + (nums.Max() * k);
        }
    }
}
