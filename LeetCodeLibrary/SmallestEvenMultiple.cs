using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SmallestEvenMultiple
    {
        public int SmallesttEvenMultiple(int n)
        {
          
            return Enumerable.Range(n, 150).Where(x => x % 2 == 0 && x % n == 0).OrderBy(x => x).FirstOrDefault();
        }
    }
}
