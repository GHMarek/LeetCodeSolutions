using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ConvertAnArrayIntoA2DArrayWithConditions
    {
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>> ();
            List<int> numsList = nums.ToList();
            int rowPointer = 0;

            while (numsList.Count > 0)
            {

                res.Add(numsList.Distinct().ToArray());

                foreach (int i in res[rowPointer])
                {
                    numsList.Remove(i);
                }

                rowPointer++;

            }

            return res;
        }
    }
}
