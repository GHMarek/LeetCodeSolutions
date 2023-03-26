using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int res = 0;

            var rows = mat.Length;
            var cols = mat[0].Length;

            if (rows == 1 && cols == 1)
            {
                return mat[0][0];
            }

            res += mat[0][0];
            res += mat[0][cols - 1];
            res += mat[rows - 1][0];
            res += mat[rows - 1][cols - 1];

            int colPointerStart = 1;
            int colPointerEnd = cols - 2;

            for (int i = 1; i <= rows - 2; i++)
            {

                if (colPointerStart != colPointerEnd)
                {
                    res += mat[i][colPointerStart];
                    res += mat[i][colPointerEnd];

                    colPointerStart++;
                    colPointerEnd--;

                    continue;
                }

                res += mat[i][colPointerEnd];

                colPointerStart++;
                colPointerEnd--;

            }

            return res;
        }
    }
}
