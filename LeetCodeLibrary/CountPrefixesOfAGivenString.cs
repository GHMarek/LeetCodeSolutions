using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountPrefixesOfAGivenString
    {
        public int CountPrefixes(string[] words, string s)
        {
            return words.Count(x => s.StartsWith(x));
        }
    }
}
