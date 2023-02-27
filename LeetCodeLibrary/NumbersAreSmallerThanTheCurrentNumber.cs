using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumbersAreSmallerThanTheCurrentNumber
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            return SmallerNumbersThanCurrentHelper(nums).ToArray();

        }

        public IEnumerable<int> SmallerNumbersThanCurrentHelper(int[] nums)
        {
            foreach (int i in nums)
            {
                yield return nums.Where(x => x != i && x < i).Count();
            }

        }

    }
}
