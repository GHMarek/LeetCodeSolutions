using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SumOfAllSubsetXORTotals
    {
        public int SubsetXORSum(int[] nums)
        {

            return XORSubsets(nums, 0, 0);
        }

        private int XORSubsets(int[] nums, int index, int res)
        {
            
            if (index == nums.Length)
            {
                return res;
            }

            return XORSubsets(nums, index + 1, res) + XORSubsets(nums, index + 1, res ^ nums[index]);

        }
    }
}
