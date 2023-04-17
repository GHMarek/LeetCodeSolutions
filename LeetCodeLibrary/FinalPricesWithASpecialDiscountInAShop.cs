using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FinalPricesWithASpecialDiscountInAShop
    {
        public int[] FinalPrices(int[] prices)
        {
            Stack<int> nextLesser = new Stack<int>();
            int localIndex = 0;
            int[] res = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {

                while(nextLesser.Count() > 0 && prices[nextLesser.Peek()] >= prices[i])
                {
                    localIndex = nextLesser.Pop();
                    res[localIndex] = prices[localIndex] - prices[i];
                    localIndex = 0;
                }

                nextLesser.Push(i);
                res[i] = prices[i];

                
            }

            return res;
        }
    }
}
