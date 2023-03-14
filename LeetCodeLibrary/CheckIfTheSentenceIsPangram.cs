using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class CheckIfTheSentenceIsPangram
    {
        public bool CheckIfPangram(string sentence)
        {
            //    var c = sentence.ToArray().OrderBy(x => x);
            //    var t = Enumerable.Range(97, 25);
            //    //97-122

            //    var g = t.Except(sentence.Select(x => (int)x).ToArray());
            //    var zz = Enumerable.Range(97, 25).Except(sentence.Select(x => (int)x).ToArray()).Count() > 0;


            for (int i = 97; i <= 122; i++)
            {
                if (sentence.Contains(Convert.ToChar(i)))
                {
                    continue;
                }

                return false;
            }


            return true;
        }
    }
}
