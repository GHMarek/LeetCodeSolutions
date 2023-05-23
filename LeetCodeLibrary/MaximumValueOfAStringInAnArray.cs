using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaximumValueOfAStringInAnArray
    {
        public int MaximumValue(string[] strs)
        {

            int res = 0;

            for (int i = 0; i < strs.Length; i++)
            {
                if (Regex.IsMatch(strs[i], @"^[0-9]+$"))
                {
                    if (Convert.ToInt32(strs[i]) > res)
                    {
                        res = Convert.ToInt32(strs[i]);
                    }

                    continue;
                }

                if (strs[i].Length > res)
                {
                    res = strs[i].Length;
                }
                
            }

            return res;
        }
    }
}
