using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SortThePeople
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            Dictionary<int, string> resDict = new Dictionary<int, string>();

            for (int i = 0; i < names.Length; i++)
            {
                resDict.Add(heights[i], names[i]);
            }

            return resDict.OrderByDescending(x => x.Key).Select(x => x.Value).ToArray();
        }
    }
}
