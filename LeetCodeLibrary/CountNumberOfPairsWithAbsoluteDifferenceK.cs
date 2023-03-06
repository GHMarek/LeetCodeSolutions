using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountNumberOfPairsWithAbsoluteDifferenceK
    {
        public int CountKDifference(int[] nums, int k)
        {

            return CountPairs(nums, k);
        }

        private int CountPairs(int[] nums, int k)
        {
            int res = 0;
            foreach (int i in nums)
            {

                res += nums.Select(x => Convert.ToInt32(i - x == k)).Sum();
            }

            return res;
        }
    }
}
