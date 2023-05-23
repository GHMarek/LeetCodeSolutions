using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class NumberOfSeniorCitizens
    {
        public int CountSeniors(string[] details)
        {
            int res = 0;

            for (int i = 0; i < details.Length; i++)
            {
                if (Convert.ToInt32(details[i].Substring(11, 2)) > 60)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
