using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecodeXORedArray
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] arr = new int[encoded.Length + 1];

            arr[0] = first;

            for (int i = 1; i < arr.Length; i++)
            {

                arr[i] = first ^ encoded[i-1];
                first = arr[i];

            }

            return new int[] { };
        }
    }
}
