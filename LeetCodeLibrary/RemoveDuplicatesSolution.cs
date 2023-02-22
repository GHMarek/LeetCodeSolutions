using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveDuplicatesSolution
    {
        public static int RemoveDuplicates(int[] arr)
        {

            int n = arr.Length;
            if (n == 0 || n == 1)
                return n;

            int[] temp = new int[n];

            int j = 0;

            for (int i = 0; i < n - 1; i++)

                if (arr[i] != arr[i + 1])
                    temp[j++] = arr[i];

            temp[j++] = arr[n - 1];

            for (int i = 0; i < j; i++)
                arr[i] = temp[i];

            return j;
        }
    }
}
