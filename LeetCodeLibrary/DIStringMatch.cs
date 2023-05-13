using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DIStringMatch
    {
        public int[] DiStringMatch(string s)
        {
            int[] perm = new int[s.Length + 1];

            List<int> permRange = Enumerable.Range(0, s.Length + 1).ToList();

            for (int i = 0; i < perm.Length; i++)
            {

                switch (s[i])
                {

                    case 'D':
                        perm[i] = permRange[permRange.Count - 1];
                        permRange.RemoveAt(permRange.Count - 1);
                        break;
                    case 'I':
                        perm[i] = permRange[0];
                        permRange.RemoveAt(0);
                        break;
                }

                if (i == s.Length - 1)
                {
                    perm[s.Length] = permRange.First();
                    break;
                }
            }
            
            return perm;
        }

    }
}
