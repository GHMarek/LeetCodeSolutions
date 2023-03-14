using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DestinationCity
    {
        public string DestCity(List<List<string>> paths)
        {

            Hashtable ht = new Hashtable();

            foreach (var i in paths)
            {
                ht.Add(i[0], i[1]);
            }

            foreach (var i in ht.Values)
            {
                if (ht.ContainsKey(i))
                {
                    continue;
                }

                return i.ToString();
            }

            return String.Empty;
        }
    }
}
