using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SumOfAllOddLengthSubarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int[] a = Enumerable.Range(1, arr.Length).Where(x => x % 2 != 0 && x != 1 && x != arr.Length).ToArray();
            int res = 0;
            int len = arr.Length;

            res += arr.Sum();

            if (len % 2 != 0 && len != 1)
            {
                foreach (var item in arr)
                {
                    res += item;
                }
            }

            foreach (var i in a)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j + i <= arr.Length)
                    {
                        res += arr.Skip(j).Take(i).Sum();
                        continue;
                    }

                    break;
                }
            }

            return res;
        }
    }
}
