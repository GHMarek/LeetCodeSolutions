using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfStepsToReduceANumberToZero
    {
        public int NumberOfSteps(int num)
        {

            int stepsCnt = 0;

            while (num > 0)
            {
                num = num % 2 == 0 ? num / 2 : num - 1;
                stepsCnt++;
            }

            return stepsCnt;
        }
    }
}
