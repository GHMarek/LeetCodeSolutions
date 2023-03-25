using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SubtractTheProductandSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {

            var digs = n.ToString().ToArray().Select(x => Int32.Parse(Convert.ToString(x)));
            int sum = 0;
            int prod = 1;


            foreach (var i in digs)
            {
                sum += i;
                prod *= i;

            }

            return prod - sum;
        }
    }
}
