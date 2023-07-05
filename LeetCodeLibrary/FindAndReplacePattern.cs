using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FindAndReplacePattern
    {
        public IList<string> FindAndReplacePatterrn(string[] words, string pattern)
        {
            List<string> res = new List<string>() { };
            

            if (pattern.Length == 1)
            {
                return words.ToList();
            }

            foreach (string i in words.Where(x => x.Distinct().Count() == pattern.Distinct().Count()))
            {
                Dictionary<char, char> replaceDict = new Dictionary<char, char>();
                char[] resArr = new char[pattern.Length];

                for (int j = 0; j < pattern.Length; j++)
                {
                    if (!replaceDict.ContainsKey(i[j]))
                    {
                        replaceDict.Add(i[j], pattern[j]);
                        
                    }

                    resArr[j] = replaceDict[i[j]];
                }

                if(new string(resArr) == pattern)
                {
                    res.Add(i);
                }


            }

            return res;
        }

        //private int[] GetPattern(string s)
        //{


        //    return patArr;
        //}
    }
}
