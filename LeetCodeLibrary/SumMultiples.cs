using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SumMultiples
    {
        public int SumOfMultiples(int n)
        {
            return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0).Sum();
        }
    }
}
