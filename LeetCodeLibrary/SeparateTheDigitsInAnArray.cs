using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SeparateTheDigitsInAnArray
    {
        public int[] SeparateDigits(int[] nums)
        {
            //var y = String.Join("", nums.Select(x => x.ToString())).Select(x => (int)Char.GetNumericValue(x));

            //var z = y.Select(x => (int)Char.GetNumericValue(x));

            return String.Join("", nums.Select(x => x.ToString())).Select(x => x - 48).ToArray();
        }
    }
}
