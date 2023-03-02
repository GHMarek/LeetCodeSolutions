using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecodeXORedArray
    {
        // undone
        public int[] Decode(int[] encoded, int first)
        {
            int[] arr = new int[encoded.Length + 1];

            arr[0] = first;

            for (int i = 0; i < encoded.Length; i++)
            {
                if(encoded[i] == arr[i])
                {
                    //arr[i + 1] = 
                }
                encoded[i] = arr[i] ^ arr[i + 1];   

            }

            return new int[] { };
        }
    }
}
