using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumNumberOfWordsFoundInSentences
    {
        public int MostWordsFound(string[] sentences)
        {
            var z = sentences.OrderByDescending(x => x.Split(' ').Count()).First().Split(' ').Count();
            var e = sentences.Select(x => x.Split(' ').Count()).Max();

            return e;
        }
    }
}
