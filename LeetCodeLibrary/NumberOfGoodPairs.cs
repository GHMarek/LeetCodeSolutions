using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {

            List<int> resLi = nums.ToList();

            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                resLi.RemoveAt(resLi.FindIndex(t => t == nums[i]));

                res += resLi.Where(t => t == nums[i]).Count();

            }

            return res;
        }
    }
}
