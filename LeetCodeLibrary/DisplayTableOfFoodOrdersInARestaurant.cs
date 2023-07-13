using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DisplayTableOfFoodOrdersInARestaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            List<List<string>> res = new List<List<string>>();
            Dictionary<string, int> tablesDict = new Dictionary<string, int>();

            // dict of dishes and quantity ordered
            foreach (var i in orders) 
            {
                string tabDish = $@"{i[2]},{i[1]}";

                if (tablesDict.ContainsKey(tabDish))
                {
                    tablesDict[tabDish] ++;
                    continue;
                }

                tablesDict.Add(tabDish, 1);

            }

            // first row of dishes/table
            res.Add(new List<string> { "Table" });

            foreach (var i in tablesDict.Select(x => x.Key.Split(',')[0]).Distinct().OrderBy(s => s, new CharValueComparer()))
            {
                res[0].Add(i);
            }
 
            // number of tables
            foreach (var i in tablesDict.Select(x => x.Key.Split(',')).Distinct().OrderBy(y => y[0]).Select(z => z[1]).Distinct())
            {
                res.Add(new List<string> { i });
            }

            // quantity of dishes
            foreach (var i in res.Skip(1))
            {
                foreach (var j in res[0].Skip(1).ToArray())
                {
                    string localKey = $@"{j},{i[0]}";
                    if (tablesDict.ContainsKey(localKey))
                    {
                        res.Where(x => x[0] == i[0]).FirstOrDefault().Add(tablesDict[$@"{j},{i[0]}"].ToString());
                        continue;

                    }

                    res.Where(x => x[0] == i[0]).FirstOrDefault().Add("0");


                }
            }

            // return IList
            IList<IList<string>> list = new List<IList<string>> { res[0] };

            var t = res.Skip(1).OrderBy(x => x.Skip(1).Sum(y => Int32.Parse(y)));

            //foreach (var i in res.Skip(1).OrderBy(x => x.Skip(1).Sum(y => Int32.Parse(y))))
            foreach (var i in res.Skip(1).OrderByDescending(x => Int32.Parse(x[0])))
            {
                list.Add(i);
            }

            return list;
        }

    }

    public class CharValueComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            for (int i = 0; i < Math.Min(x.Length, y.Length); i++)
            {
                if (x[i] != y[i])
                    return x[i].CompareTo(y[i]);
            }

            return x.Length.CompareTo(y.Length);
        }
    }
}
