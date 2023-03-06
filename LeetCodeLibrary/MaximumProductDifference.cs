using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumProductDifference
    {
        public int MaxProductDifference(int[] nums)
        {

            //int diff = 0;

            //var firstPair = nums.OrderByDescending(x => x).Take(2).ToArray().Aggregate(1, (a, b) => a * b);
            //var secondPair = nums.OrderBy(x => x).Take(2).ToArray().Aggregate(1, (a, b) => a * b);

            //diff = firstPair - secondPair;

            return nums.OrderByDescending(x => x).Take(2).ToArray().Aggregate(1, (a, b) => a * b) - nums.OrderBy(x => x).Take(2).ToArray().Aggregate(1, (a, b) => a * b);
        
        }
    }
}
