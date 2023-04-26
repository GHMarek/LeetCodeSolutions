using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumOperationsToMakeTheArrayIncreasing
    {
        public int MinOperations(int[] nums)
        {
            int res = 0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] <= (nums[i - 1] + 1))
                {
                    res += (nums[i - 1] + 1) - nums[i];
                    nums[i] = nums[i - 1] + 1;
                }

            }

            return res;
        }
    }
}
