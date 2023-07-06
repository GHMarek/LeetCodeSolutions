using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RearrangeArrayElementsBySign
    {
        public int[] RearrangeArray(int[] nums)
        {

            int[] res = new int[nums.Length];
            int positiveIndex = 0;
            int negativeIndex = 1;

            foreach (int num in nums)
            {
                if (num > 0)
                {
                    res[positiveIndex] = num;
                    positiveIndex += 2;
                }
                else
                {
                    res[negativeIndex] = num;
                    negativeIndex += 2;
                }
            }

            return res;
        }
    }
}
