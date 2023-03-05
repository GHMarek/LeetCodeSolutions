using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfArithmeticTriplets
    {
        
        public int ArithmeticTriplets(int[] nums, int diff)
        {

            int i;
            int j;
            int k;

            
            int res = 0;

            for (int pt = 0; pt < nums.Length; pt++)
            {
                List<int> tmpRes = new List<int>() { };

                int currentNum = nums.Reverse().ToArray()[pt];
                int skippedItems = 0;

                foreach (var item in nums.Reverse().Skip(pt + 1))
                {
                    skippedItems++;

                    if (currentNum - item != diff)
                    {
                        continue;
                    }

                    foreach (var inItem in nums.Reverse().Skip(pt + 1 + skippedItems))
                    {
                        if (item - inItem != diff)
                        {
                            
                            continue;
                        }
                        tmpRes.Add(currentNum);
                        tmpRes.Add(item);
                        tmpRes.Add(inItem);
                        res++;
                        break;

                    }

                    break;

                }

            }

            return res;
        }
    }
}
