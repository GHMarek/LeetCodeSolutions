using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ReversePrefixOfWord
    {
        public string ReversePrefix(string word, char ch)
        {

            char[] tempCharArr = word.ToArray();

            Array.Reverse(tempCharArr, 0, word.IndexOf(ch) + 1);

            return new string(tempCharArr);

        }
    }
}
