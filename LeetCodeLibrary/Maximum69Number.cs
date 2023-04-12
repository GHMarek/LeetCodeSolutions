using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class Maximum69Number
    {
        public int Maximum69Numberr(int num)
        {
            char[] tmp = num.ToString().ToArray();

            if (!tmp.Contains('6'))
            {
                return num;
            }

            tmp[Array.IndexOf(tmp, '6')] = '9';

            return Int32.Parse(new string(tmp));
        }
    }
}
