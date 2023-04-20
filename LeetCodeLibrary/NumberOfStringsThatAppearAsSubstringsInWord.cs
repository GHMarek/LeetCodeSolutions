using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfStringsThatAppearAsSubstringsInWord
    {
        public int NumOfStrings(string[] patterns, string word)
        {
            //var t = word.Intersect("d");
            return patterns.Where(x => word.IndexOf(x) > -1).Count();
            //return patterns.Count(x => word.Contains(x));
        }
    }
}
