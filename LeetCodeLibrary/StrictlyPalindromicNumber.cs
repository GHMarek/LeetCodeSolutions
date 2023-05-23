using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class StrictlyPalindromicNumber
    {
        public bool isStrictlyPalindromic(int n)
        {

            // bases
            for (int i = 2; i <= n - 2; i++)
            {

                string basedN = ConvertToBase(n, i);

                // Evaluate if palindromic.
                for (int j = 0, k = basedN.Length - 1; j < basedN.Length / 2; j++, k--)
                {

                    if (basedN[j] != basedN[k])
                    {
                        return false;
                    }

                }

            }

            return true;

        }

        private static string ConvertToBase(int n, int newBase)
        {
            string strBase = String.Empty;

            while (n > 0)
            {
                int reminder = n % newBase;
                strBase = reminder.ToString() + strBase;
                n /= newBase;
            }

            return strBase;
        }

    }
}
