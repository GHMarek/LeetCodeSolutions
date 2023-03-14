using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class IncreasingDecreasingString
    {
        public string SortString(string s)
        {

            Dictionary<char, int> ht = new Dictionary<char, int>() { };

            foreach (var i in s.Distinct())
            {
                ht.Add(i, s.Count(x => x == i));
            }

            StringBuilder res = new StringBuilder();

            while(ht.Values.Sum() > 0)
            {
                foreach (var i in ht.Keys.ToArray().OrderBy(x => x))
                {
                    if (ht[i] > 0)
                    {
                        ht[i] -= 1;
                        res.Append(i);
                    }

                    continue;
                }

                if (ht.Values.Sum() > 0)
                {
                    foreach (var i in ht.Keys.ToArray().OrderByDescending(x => x))
                    {
                        if (ht[i] > 0)
                        {
                            ht[i] -= 1;
                            res.Append(i);
                        }

                        continue;
                    }
                }

            }

            return res.ToString();
        }
    }
}
