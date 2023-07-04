using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumOperationsToMakeArrayEqual
    {
        /*
        // alt
        public int MinOperations(int n) 
        {
            return (n / 2) * (n - (n / 2));
        }

        return (n*n)/4;
        */

        public int MinOperations(int n)
        {

            int res = 0;

            if (n == 1)
            {
                return res;
            }

            int[] arr = GetArray(n);

            int avgArr = (int)arr.Average();

            for (int i = 0; i < n; i++)
            {
                res += arr[i] > avgArr ? arr[i] - avgArr : avgArr - arr[i];
            }

            return res / 2;
        }

        private int[] GetArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = (2 * i) + 1;
            }

            return arr;
        }
        }
}
