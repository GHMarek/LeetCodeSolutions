using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class QueriesOnAPermutationWithKey
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            List<int> P = Enumerable.Range(1, m).ToList();
            int[] res = new int[queries.Length]; 

            for (int i = 0; i < queries.Length; i++)
            {
                int tmpIdx = P.IndexOf(queries[i]);

                P.RemoveAt(tmpIdx);
                P.Insert(0, queries[i]);
                res[i] = tmpIdx;

            }

            return res;
        }
    }
}
