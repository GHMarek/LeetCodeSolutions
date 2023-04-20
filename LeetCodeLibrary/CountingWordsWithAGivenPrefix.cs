using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CountingWordsWithAGivenPrefix
    {
        public int PrefixCount(string[] words, string pref)
        {
            //int res = 0;

            //foreach (string i in words.Where(x => x[0] == pref[0]))
            //{
            //    if (i.StartsWith(pref))
            //    {
            //        res++;
            //    }
            //}


            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i][0] != pref[0])
            //    {
            //        continue;
            //    }

            //    if (words[i].StartsWith(pref))
            //    {
            //        res++;
            //    }
            //}


            // fastest
            return words.Count(x => x.StartsWith(pref));
            //return words.Where(x => x.StartsWith(pref)).Count();
        }
    }
}
