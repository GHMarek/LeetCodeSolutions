using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class TwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            
            return String.Join("", word1) == String.Join("", word2);
        }
    }

}
