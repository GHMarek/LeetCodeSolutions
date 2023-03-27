using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumPathSum
    {
        
        public int MinPathSum(int[][] grid)
        {

            int gridV = grid.Length;
            int gridH = grid[0].Length;

            int startTile = grid[0][0];


            for (int i = 0; i < gridV; i++)
            {
                for (int j = 0; j < gridH; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                        continue;
                    }

                    if (j == 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                        continue;
                    }

                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);

                }

            }

            return grid[gridV - 1][gridH - 1];






        }
    }
}
