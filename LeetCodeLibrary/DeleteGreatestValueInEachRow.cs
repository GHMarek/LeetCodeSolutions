using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DeleteGreatestValueInEachRow
    {
        public int DeleteGreatestValue(int[][] grid)
        {

            int res = 0;

            foreach (int[] i in grid)
            {
                Array.Sort(i);
            }

            for (int i = 0; i < grid[0].Length; i++)
            {
                // Get max of index i in every subarray.
                res += grid.Max(k => k[i]);
            }

            return res;
        }
    }
}
