using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumNumberOfPairsInArray
    {
        public int[] NumberOfPairs(int[] nums)
        {
            int pairs = 0;
            int leftovers = 0;

            foreach (int i in nums.Distinct())
            {
                int t = nums.Count(x => x == i);
                bool tt = (t % 2 == 0);

                switch (tt)
                {
                    case true:
                        pairs += t / 2;
                        break;
                    case false:
                        pairs += (t - 1) / 2;
                        leftovers += 1;
                        break;
                }

            }

            return new int[] { pairs, leftovers };
        }
    }
}
