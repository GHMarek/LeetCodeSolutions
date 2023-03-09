using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            var c = s.Split(' ');
            StringBuilder x = new StringBuilder();

            foreach (string i in c)
            {
                x.Append($@"{' '}{String.Join("", i.Reverse())}");
            }

            return x.ToString().TrimStart();
        }
    }

}
