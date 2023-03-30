using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class QueriesOnNumberOfPointsInsideACircle
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] answer = new int[queries.Length];
            int x = 0;
            int y = 0;
            int r = 0;

            for (int i = 0; i < queries.Length; i++)
            {
                x = queries[i][0];
                y = queries[i][1];
                r = queries[i][2];
                answer[i] = 0;

                foreach (var j in points)
                {

                    if ((Math.Pow((j[0] - x), 2) + Math.Pow((j[1] - y), 2)) <= Math.Pow(r, 2))
                    {
                        answer[i] += 1;
                        continue;
                    }

                }

            }

            return answer;
        }
    }
}
