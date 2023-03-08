using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SplitAStringInBalancedString
    {
        public int BalancedStringSplit(string s)
        {

            string lastChar = s.Substring(0, 1);
            int res = 0;
            string strB = String.Empty;

            foreach (var i in s.Substring(1))
            {

                if (String.IsNullOrEmpty(lastChar) && String.IsNullOrEmpty(strB))
                {
                    lastChar = Convert.ToString(i);
                    continue;
                }

                if(!String.IsNullOrEmpty(lastChar) && i != Char.Parse(lastChar))
                {
                    res += 1;
                    lastChar = String.Empty;
                    continue;
                }

                if (!String.IsNullOrEmpty(strB))
                {

                    strB += Convert.ToString(i);

                    if (strB.Count(x => x == 'L') == strB.Count(x => x == 'R'))
                    {
                        res += 1;
                        strB = String.Empty;
                        continue;
                    }

                    continue;

                }

                if (String.IsNullOrEmpty(strB) && !String.IsNullOrEmpty(lastChar))
                {
                    strB += Convert.ToString(lastChar);
                    lastChar = String.Empty;
                }

                strB += Convert.ToString(i);

            }

            return res;

        }
    }
}
