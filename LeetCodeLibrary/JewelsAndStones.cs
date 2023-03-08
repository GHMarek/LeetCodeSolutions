using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {

            int res = 0;

            for (int i = 0; i < jewels.Length; i++)
            {
                res += stones.Count(x => x == jewels[i]);
                
            }

            return res;
        }
    }
}
