using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SortingTheSentence
    {
        public string SortSentence(string s)
        {

            string[] res = new string[s.Split(' ').Count()];

            foreach (var item in s.Split(' '))
            {
                res[Int32.Parse(Regex.Replace(item, @"[A-z]", "")) - 1] = Regex.Replace(item, @"\d", "");
            }

            return String.Join(" ", res);
        }
    }
}
