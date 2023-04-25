using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CellsWithOddValuesInAMatrix
    {
        public int OddCells(int m, int n, int[][] indices)
        {

            int[,] mx = new int[m,n];

            for (int i = 0; i < indices.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mx[indices[i][0], j] += 1;
                }


                for (int k = 0; k < m; k++)
                {
                    mx[k, indices[i][1]] += 1;
                }
            }

            return (from i in mx.Cast<int>() where i % 2 != 0 select i).Count();
        }
    }
}
