using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MergeSimilarItems
    {
        public IList<IList<int>> MergeSimilarItemss(int[][] items1, int[][] items2)
        {

            List<IList<int>> res = new List<IList<int>>() { }; ;

            Dictionary<int, int> ite1Dict = new Dictionary<int, int>();
            Dictionary<int, int> ite2Dict = new Dictionary<int, int>();

            for (int i = 0; i < items1.Length; i++)
            {
                ite1Dict.Add(items1[i][0], items1[i][1]);

            }

            for (int i = 0; i < items2.Length; i++)
            {
                ite2Dict.Add(items2[i][0], items2[i][1]);
            }

            var resultDict = new Dictionary<int, int>();

            foreach (var dict in new List<Dictionary<int, int>>() { ite1Dict, ite2Dict })
            {
                foreach (var x in dict) 
                {

                    if (resultDict.ContainsKey(x.Key))
                    {
                        resultDict[x.Key] += x.Value;
                        continue;
                    }

                    resultDict[x.Key] = x.Value;
                }
                    
            }

            foreach (var i in resultDict)
            {
                res.Add(new int[] { i.Key, i.Value });
            }

            res = res.OrderBy(x => x[0]).ToList<IList<int>>();
            
            return res;
        }
    }
}
