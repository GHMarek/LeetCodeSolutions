using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ReplaceAllDigitsWithCharacters
    {
        public string ReplaceDigits(string s)
        {
            StringBuilder res = new StringBuilder();
            int evenLen = s.Length % 2 == 0 ? s.Length : s.Length - 1;

            for (int i = 0; i < evenLen; i += 2)
            {
                var c = (int)s[i] + Int32.Parse(Convert.ToString(s[i + 1]));

                res.Append($@"{s[i]}{(char)((int)s[i] + Int32.Parse(Convert.ToString(s[i + 1])))}");
            }

            if (res.Length < s.Length)
            {
                res.Append(s[evenLen]);
            }

            return res.ToString();
        }
    }
}
