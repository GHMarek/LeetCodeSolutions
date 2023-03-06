using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class LargestLocalValuesInAMatrix
    {
        // TODO: unsolved
        public int[][] LargestLocal(int[][] grid)
        {

            int len = grid.Length;
            int newLen = len - 2;

            int[][] resMatrix = GetMatrix(newLen);

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {

                }
            }

            return new int[][] { };
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
