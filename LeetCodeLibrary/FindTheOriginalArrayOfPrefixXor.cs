using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindTheOriginalArrayOfPrefixXor
    {
        public int[] FindArray(int[] pref)
        {

            int[] res = new int[pref.Length];
            res[0] = pref[0];

            for (int i = 1; i < pref.Length; i++)
            {

                res[i] = pref[i - 1] ^ pref[i];
            }

            return new int[] { };
        }
    }
}
