using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LargestLocalValuesInAMatrix
    {

        public int[][] LargestLocal(int[][] grid)
        {

            int len = grid.Length;
            int newLen = len - 2;

            int[][] resMatrix = GetMatrix(newLen);

            for (int i = 0; i < newLen; i++)
            {
                for (int j = 0; j < newLen; j++)
                {
                    var row1 = grid[i].Skip(j).Take(3);
                    var row2 = grid[i + 1].Skip(j).Take(3);
                    var row3 = grid[i + 2].Skip(j).Take(3);

                    int[] localMax = new int[] { 
                        
                        grid[i].Skip(j).Take(3).Max()
                        , grid[i + 1].Skip(j).Take(3).Max()
                        , grid[i + 2].Skip(j).Take(3).Max() 

                    };

                    resMatrix[i][j] = localMax.OrderByDescending(x => x).First();
                }
            }

            return resMatrix;
        }

        private static int[][] GetMatrix(int l)
        {
            int[][] resMatrix = new int[l][];

            for (int i = 0; i < resMatrix.Length; i++)
            {
                resMatrix[i] = new int[l];
            }

            return resMatrix;
        }



    }
}
