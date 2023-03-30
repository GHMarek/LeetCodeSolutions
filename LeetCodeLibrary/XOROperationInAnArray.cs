using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class XOROperationInAnArray
    {
        public int XorOperation(int n, int start)
        {

            int res = start + 2 * 0;

            for (int i = 1; i < n; i++)
            {

                 res = res ^ (start + 2 * i);

            }

            return res;
        }
    }
}
