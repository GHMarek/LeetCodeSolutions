using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                int temp = target - nums[i];


                if (hashSet.Contains(temp))
                {

                    return new int[] { Array.IndexOf(nums, nums[i]), Array.LastIndexOf(nums, temp) };

                }

                hashSet.Add(nums[i]);
            }

            return new int[0];
        }
    }
}
