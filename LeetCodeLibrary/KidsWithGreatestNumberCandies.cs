using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class KidsWithGreatestNumberCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            return KidsWithCandiesHelper(candies, extraCandies).ToList();
        }

        public IEnumerable<bool> KidsWithCandiesHelper(int[] candies, int extraCandies)
        {
            foreach (int i in candies)
            {
                yield return i + extraCandies >= candies.Max();
            }
        }

    }
}
