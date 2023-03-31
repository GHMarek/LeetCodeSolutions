using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MaxIncreaseToKeepCitySkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int lenInd = grid.Length - 1;
            int resSum = 0;

            for (int col = 0; col <= lenInd; col++)
            {
                int colMax = 0;

                for (int row = 0; row <= lenInd; row++)
                {
                    colMax = grid[row][col] > colMax ? grid[row][col] : colMax;

                }

                for (int row = 0; row <= lenInd; row++)
                {

                    int localMax = Math.Min(grid[row].Max(), colMax);
                    int localHeight = grid[row][col];

                    if (localMax > localHeight)
                    {
                        resSum += localMax - localHeight;
                    }

                }

                
            }


            return resSum;
        }
    }
}
