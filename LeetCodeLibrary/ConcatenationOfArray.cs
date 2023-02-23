using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int len = nums.Length;
            int[] x = new int[len * 2];


            foreach (int i in Enumerable.Range(0, 3))
            {
                x[i] = nums[i];
                x[i + len] = nums[i];
            }

            //for (int i = 0; i < len; i++)
            //{
            //    x[i] = nums[i];
            //    x[i + len] = nums[i];
            //}

            return x;
        }
    }
}
