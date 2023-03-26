using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SubrectangleQueries
    {
        private int[][] getRect = null;
        public SubrectangleQueries(int[][] rectangle)
        {
            getRect = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {

            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    getRect[i][j] = newValue;
                }
            }

        }

        public int GetValue(int row, int col)
        {
            return getRect[row][col];
        }
    }
}
