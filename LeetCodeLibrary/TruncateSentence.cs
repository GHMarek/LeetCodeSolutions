using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class TruncateSentence
    {
        public string TruncateSentencee(string s, int k)
        {

            return String.Join(" ", s.Split(' ').Take(k));
        }
    }
}
