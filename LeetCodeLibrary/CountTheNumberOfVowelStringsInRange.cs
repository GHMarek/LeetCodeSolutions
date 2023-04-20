using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountTheNumberOfVowelStringsInRange
    {
        public int VowelStrings(string[] words, int left, int right)
        {

            return words.Skip(left).Take(right - left + 1).Count(x => "aeiou".Contains(x[0]) && "aeiou".Contains(x[x.Length - 1]));
            
        }
    }
}
