using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CellsInARangeOnAnExcelSheet
    {
        public IList<string> CellsInRange(string s)
        {
            int a = (int)Char.Parse(s.Substring(0, 1));
            int z = (int)Char.Parse(s.Substring(3, 1));
            int x = Int32.Parse(s.Substring(1, 1));
            int y = Int32.Parse(s.Substring(4, 1));

            IEnumerable<int> charRange = Enumerable.Range(a, z - a + 1);
            IEnumerable<int> intRange = Enumerable.Range(x, y - x + 1);

            List<string> res = new List<string>() { };

            foreach (var i in charRange)
            {
                foreach (var j in intRange)
                {
                    res.Add($@"{Convert.ToChar(i)}{j}");
                }
            }

            return res;
        }
    }
}
