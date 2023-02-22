using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class BuildArrayFromPermutation
    {
        public int[] BuildArray(int[] nums)
        {

            int i = 0;
            return (from num in nums select nums[nums[i++]]).ToArray();
        }
    }
}

