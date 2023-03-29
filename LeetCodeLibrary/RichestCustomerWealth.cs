using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int res = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int wealth = accounts[i].Sum();
                if (wealth > res)
                {
                    res = wealth;
                }
            }

            return res;
        }
    }
}
