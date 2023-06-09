using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DeleteColumnsToMakeSorted
    {
        public int MinDeletionSize(string[] strs)
        {

            List<int> indicesToDelete = new List<int>() { };

            for (int i = 1; i < strs.Length; i++)
            {
                IEnumerable<int> rowIndices = Enumerable.Range(0, strs[0].Length).Except(indicesToDelete);

                foreach (var j in rowIndices)
                {
                    if (strs[i][j] < strs[i - 1][j])
                    {
                        indicesToDelete.Add(j);
                    }
                }

            }

            return indicesToDelete.Count();
        }
    }
}
