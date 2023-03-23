using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new List<IList<int>>() { }; ;

            for (int i = 0; i < numRows; i++)
            {

                switch (i)
                {
                    case 0:
                        res.Add(new int[] { 1 } );
                        break;

                    case 1:
                        res.Add(new int[] { 1, 1 });
                        break;

                    default:
                        DefaultSwitch(res, i);
                        break;

                }

            }

            return res;
        }

        private static void DefaultSwitch(List<IList<int>> res, int i)
        {
            int[] row = new int[i + 1];

            row[0] = 1;
            row[i] = 1;

            for (int j = 1; j <= i - 1; j++)
            {
                // -1 bo to index listy, w której są rows

                var t = res[i - 1][j];
                var tt = res[i - 1][j - 1];

                row[j] = t + tt;
            }

            res.Add(row);
        }
    }
}
