using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RunningSumOf1dArray
    {
        //public int[] RunningSum(int[] nums)
        //{
        //    int[] res = new int[nums.Length];

        //    for (int i = 1; i <= nums.Length; i++)
        //    {
        //        res[i - 1] = nums.Take(i).Sum();

        //    }

        //    return res;
        //}

        // alt
        public int[] RunningSum(int[] nums)
        {
            return RunningSum(nums).ToArray();
        }
        public IEnumerable<int> RunningSumHelper(int[] nums)
        {
            int res = 0;

            foreach (int i in nums)
            {
                res += i;
                
                yield return res;
                
            }

        }

    }
}
