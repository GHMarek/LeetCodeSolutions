using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecodeTheMessage
    {
        private Dictionary<char, int> subTab = new Dictionary<char, int>() { };
        public string DecodeMessage(string key, string message)
        {

            foreach (var i in Enumerable.Range(97, 26))
            {
                subTab.Add(Convert.ToChar(i), key.IndexOf(Convert.ToString(Convert.ToChar(i))));
            }

            int cnt = 97;
            foreach (var i in subTab.OrderBy(x => x.Value))
            {
                subTab[i.Key] = cnt;
                cnt++;
            }


            return String.Join("", message.Select(x => GetSubst(x)));
        }

        private char GetSubst(char ch)
        {
            if (ch == ' ')
            {
                return ' ';
            }

            var c = subTab[ch];

            return Convert.ToChar(c);
        }
    }
}
