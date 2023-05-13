using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumTimeVisitingAllPoints
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int res = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                res += Math.Max(Math.Abs((points[i + 1][0] - points[i][0])), Math.Abs((points[i + 1][1] - points[i][1])));

            }

            return res;
        }
    }
}
