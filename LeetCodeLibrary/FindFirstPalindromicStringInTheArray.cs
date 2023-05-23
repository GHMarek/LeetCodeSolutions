using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindFirstPalindromicStringInTheArray
    {
        public string FirstPalindrome(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].SequenceEqual(words[i].Reverse()))
                {
                    return words[i];
                }
            }

            return String.Empty;

        }
    }
}
