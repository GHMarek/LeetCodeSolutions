using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FinalValue
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            //x = 0 + operations.Where(y => y.Contains("+")).Count() - operations.Where(y => y.Contains("-")).Count();
            
            for (int i = 0; i < operations.Length; i++)
            {
                x = x + (operations[i].Contains("+") ? 1 : -1);
            }

            //foreach (string op in operations)
            //{

            //    if (op.Contains("+"))
            //    {
            //        x++;
            //        continue;
            //    }

            //    x--;
            //}

            return x;
        }
    }
}
