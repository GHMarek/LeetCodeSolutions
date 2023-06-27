using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LexicographicallySmallestPalindrome
    {
        public string MakeSmallestPalindrome(string s)
        {
            char[] sArr = s.ToArray();

            for (int i = 0, j = s.Length - 1; j >= s.Length / 2; j--, i++)
            {
                if (s[i] != s[j])
                {
                    if (s[i] < s[j])
                    {
                        sArr[j] = s[i];

                        continue;
                    }

                    sArr[i] = s[j];

                }
            }

            return new string(sArr);
        }
    }
}
