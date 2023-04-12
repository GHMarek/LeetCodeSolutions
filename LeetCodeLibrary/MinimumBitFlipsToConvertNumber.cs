using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumBitFlipsToConvertNumber
    {
        public int MinBitFlips(int start, int goal)
        {
            string s = Convert.ToString(start, 2);
            string g = Convert.ToString(goal, 2);

            int len = Math.Max(s.Length, g.Length);

            s = s.PadLeft(len, '0');
            g = g.PadLeft(len, '0');


            int flips = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == g[i])
                {
                    continue;
                }

                flips++;
            }


            return flips;
        }
    }
}
