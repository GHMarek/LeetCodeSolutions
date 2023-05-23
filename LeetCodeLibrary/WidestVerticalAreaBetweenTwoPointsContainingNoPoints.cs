using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {

            int[] areas = SortAreas(points);
            int res = 0;

            for (int i = 1; i < areas.Length; i++)
            {
                if(res < (areas[i] - areas[i - 1]))
                {
                    res = (areas[i] - areas[i - 1]);
                }
                
            }

            return res;
        }

        public int[] SortAreas(int[][] points)
        {

            int[] res = new int[points.Length];
            

            for (int i = 0; i < points.Length; i++)
            {
                res[i] = points[i][0];
            }

            Array.Sort(res);

            return res;
        }
    }

}
