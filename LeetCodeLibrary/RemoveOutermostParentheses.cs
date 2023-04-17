using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveOutermostParentheses
    {
        public string RemoveOuterParentheses(string s)
        {

            string res = String.Empty;
            string localRes = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0)
                {
                    localRes += s[i];

                    if(localRes.Count(x => x == ')') == localRes.Count(x => x == '('))
                    {
                        localRes = localRes.Substring(1, localRes.Length - 2);
                        res += localRes;
                        localRes = String.Empty;
                    }
                    continue;
                }


                localRes += s[i];
            }

            return res;
        }
    }
}
