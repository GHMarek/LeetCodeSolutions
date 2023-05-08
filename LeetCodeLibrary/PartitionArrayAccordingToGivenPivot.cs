using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class PartitionArrayAccordingToGivenPivot
    {
        public int[] PivotArray(int[] nums, int pivot)
        {

            List<int> lessThan = new List<int>();
            List<int> equalT = new List<int>();
            List<int> greaterThan = new List<int>();

            foreach (int i in nums)
            {
                switch (i)
                {
                    case var expression when i < pivot:
                        lessThan.Add(i);
                        break;
                    case var expression when i == pivot:
                        equalT.Add(i);
                        break;
                    case var expression when i > pivot:
                        greaterThan.Add(i);
                        break;
                }
            }

            List<int> res = new List<int>();

            res.AddRange(lessThan);
            res.AddRange(equalT);
            res.AddRange(greaterThan);

            return res.ToArray();
        }
    }
}
