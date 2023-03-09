using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountAsterisks
    {
        public int CountAsteriskss(string s)
        {
            var c = s.Split('|');
            int res = 0;

            for (int i = 0; i < c.Length; i+=2)
            {
                res += c[i].Count(x => x == '*');
            }

            return res;
        }
    }
}
