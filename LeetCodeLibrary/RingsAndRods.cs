using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RingsAndRods
    {
        public int CountPoints(string rings)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>() { };

            string[] c = Regex.Replace(rings, @"\D+\w", @" $&").Split(' ').Where(x => x.Length > 1).ToArray();


            foreach (var i in c.Select(x => Convert.ToInt32(x.Substring(1))).Distinct())
            {
                var t = Convert.ToInt32(i);
                var u = c.Where(x => Convert.ToInt32(x.Substring(1)) == t).Select(x => x).Distinct().Count();

                dict.Add(t, u);
            }


            return dict.Where(x => x.Value == 3).Count();
        }
    }
}
