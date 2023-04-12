using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountGoodTriplets
    {
        public int CountGoodTripletss(int[] arr, int a, int b, int c)
        {
            int res = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                res++;
                                continue;
                            }
                        }
                    }

                }
            }

            return res;
        }
    }
}
