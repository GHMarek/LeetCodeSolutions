using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfLaserBeamsInABank
    {
        public int NumberOfBeams(string[] bank)
        {
            int res = 0;
            int prevRowCnt = 0;


            for (int i = 0; i < bank.Length; i++)
            {
                int onesCnt = bank[i].Count(x => x == '1');

                if (i == 0)
                {
                    prevRowCnt = onesCnt;
                    continue;
                }

                if (onesCnt > 0)
                {
                    res += prevRowCnt * onesCnt;
                    prevRowCnt = onesCnt;

                }

            }


            return res;
        }
    }
}
