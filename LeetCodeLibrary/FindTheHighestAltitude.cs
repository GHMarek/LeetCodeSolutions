using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindTheHighestAltitude
    {
        public int LargestAltitude(int[] gain)
        {

            int[] res = new int[gain.Length + 1];

            res[0] = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                res[i + 1] = res[i] + gain[i];
            }

            return res.Max();
        }
    }
}
