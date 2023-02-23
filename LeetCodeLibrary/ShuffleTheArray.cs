using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            //int len = nums.Length;
            int nIndex = nums.Length / 2;
            int[] ans = new int[nums.Length];

            //int[] first = nums.Take(nIndex).ToArray();
            //int[] second = nums.Skip(nIndex).ToArray();


            int cnt = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {

                ans[cnt] = nums[i];
                cnt++;

                ans[cnt] = nums[nIndex + i];
                cnt++;
            }



            return ans;
        }
    }
}
