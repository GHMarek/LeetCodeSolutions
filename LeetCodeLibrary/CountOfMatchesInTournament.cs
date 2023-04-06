using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountOfMatchesInTournament
    {
        public int NumberOfMatches(int n)
        {
            int res = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    res += n / 2;
                    n = n / 2;
                    continue;
                }

                res += (n - 1) / 2;
                n = (n - 1) / 2 + 1;

            }

            return res;
        }
    }
}
