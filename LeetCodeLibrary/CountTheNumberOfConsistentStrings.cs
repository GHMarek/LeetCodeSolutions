
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountTheNumberOfConsistentStrings
    {

        public int CountConsistentStrings(string allowed, string[] words)
        {
            int res = words.Length;

            foreach (var i in words)
            {

                if (i.Select(x => allowed.Contains(x)).Any(x => x == false))
                {
                    res--;
                }
            }

            return res;
        }

    }
}
