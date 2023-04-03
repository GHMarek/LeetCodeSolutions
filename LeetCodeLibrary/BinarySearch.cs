using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class BinarySearch
    {
        // https://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1
        public int Search(int[] nums, int target)
        {

            int minIndex = 0;
            int maxIndex = nums.Length;


            if (nums.Length == 0)
            {
                return -1;
            }

            while(true)
            {
                int mid = (minIndex + maxIndex) / 2;

                if (mid >= maxIndex)
                {
                    return -1;
                }

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    minIndex = mid + 1;
                }

                if (target < nums[mid])
                {
                    maxIndex = mid - 1;
                }

            }

            // return nums.ToList().IndexOf(target);
        }
    }
}
