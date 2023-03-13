using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class KeepMultiplyingFoundValuesByTwo
    {
        public int FindFinalValue(int[] nums, int original)
        {

            while (nums.Contains(original))
            {
                original = original * 2;
            }

            return original;
        }
    }
}
