using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumNestingDepthOfTheParentheses
    {
        public int MaxDepth(string s)
        {
            int maxDepth = 0;
            int res = 0;

            foreach (int i in s.ToArray())
            {
                if (i == 40)
                {
                    maxDepth++;
                    if (maxDepth > res)
                    {
                        res = maxDepth;
                    }
                    continue;
                }

                if (i == 41)
                {
                    maxDepth--;
                    continue;
                }

            }

            return res;
        }
    }
}

