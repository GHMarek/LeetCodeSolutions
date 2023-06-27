using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindMaximumNumberOfStringPairs
    {
        public int MaximumNumberOfStringPairs(string[] words)
        {
            int res = 0;

            for (int i = 0; i < words.Length; i++)
            {

                string[] tmpPairs = words.Where(x => x == words[i] ||
                                        x == new string(words[i].Reverse().ToArray())
                                        ).ToArray();

                if(tmpPairs.Count() > 1)
                {
                    res += tmpPairs.Count() - 1;
                    words = words.Except(tmpPairs).ToArray();
                    i--;
                }
                
            }

            return res;
        }
    }
}
