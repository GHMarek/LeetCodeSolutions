using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class GenerateAStringWithCharactersThatHaveOddCounts
    {
        public string GenerateTheString(int n)
        {

            return Enumerable.Repeat("a", n).Count() % 2 != 0 ? 
                new string(Enumerable.Repeat('a', n).ToArray()) : 
                new string(Enumerable.Repeat('a', n - 1).ToArray()) + 'b';
       
        }
    }
}
