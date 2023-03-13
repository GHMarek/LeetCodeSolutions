using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MakeArrayZeroBySubtractingEqualAmounts
    {
        private int min = 0;
        private int cnt = 0;
        public int MinimumOperations(int[] nums)
        {
            while (nums.Sum() != 0)
            {
                min = nums.Where(y => y != 0).Min();

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = nums[i] > 0 ? nums[i] - min : nums[i];
                }

                cnt++;

            }

            return cnt;
        }

    }
}
