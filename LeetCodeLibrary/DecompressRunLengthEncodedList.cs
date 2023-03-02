using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            int[] res = new int[] { };

            for (int i = 0; i < nums.Length; i+=2)
            {

                res = res.Concat(Enumerable.Repeat(nums[i + 1], nums[i])).ToArray();

            }

            return res;
        }
    }
}
