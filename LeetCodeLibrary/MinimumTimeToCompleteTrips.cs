using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumTimeToCompleteTrips
    {
        public long MinimumTime(int[] time, int totalTrips)
        {

            if (time.Length == 1)
            {
                return time[0] / totalTrips;
            }

            long start = 0;
            long maxTot = (long)time.Max() * totalTrips;
            long mid;

            while (start < maxTot)
            {
                mid = (start + maxTot) / 2;
                long sum = 0;

                foreach (var vv in time)
                {
                    sum += mid / vv;
                }

                if (totalTrips <= sum)
                {
                    maxTot = mid;
                    continue;
                }

                start = mid + 1;

            }

            return start;
        }
    }
}
