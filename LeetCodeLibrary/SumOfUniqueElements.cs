using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SumOfUniqueElements
    {
        public int SumOfUnique(int[] nums)
        {

            var z = nums.Distinct().ToDictionary(x => x, x => nums.Where(y => y == x).Sum()).Where(x => x.Key == x.Value).Select(x => x.Value).Sum();
            return 0;
        }
    }
}
