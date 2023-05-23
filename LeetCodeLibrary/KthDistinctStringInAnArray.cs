using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class KthDistinctStringInAnArray
    {
        public string KthDistinct(string[] arr, int k)
        {

            Dictionary<string, int> x = new Dictionary<string, int>() { };

            for (int i = 0; i < arr.Length; i++)
            {
                if (x.ContainsKey(arr[i]))
                {
                    x[arr[i]] = x[arr[i]] + 1;
                    
                    continue;
                }

                x.Add(arr[i], 1);
            }

            return x.Where(y => y.Value == 1).Skip(k - 1).Select(y => y.Key).DefaultIfEmpty(String.Empty).First();
        }
    }
}
