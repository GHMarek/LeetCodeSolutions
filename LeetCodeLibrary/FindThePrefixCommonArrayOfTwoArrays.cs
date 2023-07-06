using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindThePrefixCommonArrayOfTwoArrays
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            int[] res = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                res[i] = A.Take(i).Intersect(B.Take(i)).Count();
            }

            return res;
        }
    }
}
