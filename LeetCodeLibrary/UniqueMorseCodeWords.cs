using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            List<string> res = new List<string>();

            string[] morseAlpha = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            StringBuilder sB = new StringBuilder();
            
            for (int i = 0; i < words.Length; i++)
            {
                sB.Clear();

                foreach (char c in words[i])
                {
                    sB.Append(morseAlpha[(int)c - 97]);
                }

                res.Add(sB.ToString());

            }

            return res.Distinct().Count();
        }
    }
}
