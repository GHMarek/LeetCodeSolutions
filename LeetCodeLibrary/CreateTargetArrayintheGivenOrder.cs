using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CreateTargetArrayintheGivenOrder
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {

            int[] target = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                //int val = nums[i];
                //int ind = index[i];

                if(index[i] < i)
                {
                    //var g = target.Take(index[i]).ToArray();
                    //var h = target.Skip(index[i]).ToArray();
                    
                    target = target.Take(index[i]).ToArray().Concat(new int[] { nums[i] }).Concat(target.Skip(index[i]).ToArray()).ToArray();

                    continue;

                }

                target[index[i]] = nums[i];

            }

            Array.Resize(ref target, index.Length);

            return target;
        }
    }
}
