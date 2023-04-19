using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {

            string x = String.Empty;
            int maxLen = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLen; i++)
            {
                if (i < word1.Length)
                {
                    x += word1[i];
                }

                if(i < word2.Length)
                {
                    x += word2[i];
                }

            }

            return x;
        }
    }
}
