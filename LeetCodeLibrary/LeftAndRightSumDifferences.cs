using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LeftAndRightSumDifferences
    {
        public int[] LeftRigthDifference(int[] nums)
        {

            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                res[i] = Math.Abs(nums.Take(i).Sum() - nums.Skip(i + 1).Sum());

            }

            return res;
        }
    }
}
