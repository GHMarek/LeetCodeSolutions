using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {

            char[] res = new char[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {

                res[indices[i]] = new StringBuilder(s)[i];

            }

            return new string(res);
        }



    }
}
