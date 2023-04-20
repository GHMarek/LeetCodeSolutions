using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            StringBuilder sB = new StringBuilder();
            int index = 0;

            while (index < s.Length)
            {
                if (index + 1 == s.Length)
                {
                    sB.Append(((char)(int.Parse($@"{s[index]}") + 96)).ToString());
                    break;
                }

                if (index + 2 == s.Length)
                {
                    sB.Append(((char)(int.Parse($@"{s[index]}") + 96)).ToString());
                    sB.Append(((char)(int.Parse($@"{s[index + 1]}") + 96)).ToString());

                    break;
                }

                if (s[index + 2] == '#')
                {

                    sB.Append(((char)(int.Parse($@"{s[index]}{s[index + 1]}") + 96)).ToString());

                    index += 3;

                    continue;
                }

                sB.Append(((char)(int.Parse($@"{s[index]}") + 96)).ToString());
                index++;
            }

            return sB.ToString();
        }
    }
}
