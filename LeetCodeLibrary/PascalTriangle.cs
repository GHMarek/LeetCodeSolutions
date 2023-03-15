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

                if (i < 2)
                {
                    var c = Enumerable.Repeat("1", i + 1).ToArray().Select(x => Int32.Parse(x)).ToArray();

                    res.Add(c);

                    continue;
                }

                int[] row = new int[i];

                row[0] = 1;
                row[i - 1] = 1;

                for (int j = 0; j < i - 1; j++)
                {

                    var t = res[i - 2][j + 1];
                    var tt = res[i - 2][j];
                    row[j] = res[i - 2][j] + res[i - 2][j + 1];
                    res.Add(row);

                }

                //res.AddRange();
            }


            return res;
        }
    }
}
