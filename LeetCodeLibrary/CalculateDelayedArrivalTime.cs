using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CalculateDelayedArrivalTime
    {
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            int time = arrivalTime + delayedTime;
            var t = time / 24;

            switch (time / 24)
            {
                case 0:

                    if (time == 24)
                    {
                        return 0;
                    }

                    return time;

                case 1:

                    time = time - 24;

                    if (time == 24)
                    {
                        return 0;
                    }

                    return time;


                case 2:

                    time = time - 48;

                    if (time == 24)
                    {
                        return 0;
                    }

                    return time;

                default:

                    return 0;

            }

        }
    }
}
