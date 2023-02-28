using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DifferenceBetweenElementSumAndDigitSum
    {
        public int DifferenceOfSum(int[] nums)
        {

            int eleSum = nums.Sum();
            int digSum = string.Join("", nums).Select(x => Int32.Parse(x.ToString())).ToArray().Sum();

            var c = nums.Select(x => Int32.Parse(x.ToString())).Sum();

            Math.Abs(nums.Sum() - string.Join("", nums).Select(x => Int32.Parse(x.ToString())).Sum());
            

            return Math.Abs(eleSum - digSum);
        }
    }

    /*
     * this is actualy 90% faster solution
     * 
     *public int DifferenceOfSum(int[] nums) {
        int sumNumber = 0, sumDigit = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sumNumber += nums[i];
            sumDigit += DigitSum(nums[i]);
        }

        return Math.Abs(sumNumber - sumDigit);
    }
    private int DigitSum(int n)
    {
        int s = 0;
        while(n > 0)
        {
            s += n% 10;
            n /= 10;
        }
        return s;
    }

    */
}
