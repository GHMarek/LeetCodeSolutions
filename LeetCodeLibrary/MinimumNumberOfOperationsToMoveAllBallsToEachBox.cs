using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumNumberOfOperationsToMoveAllBallsToEachBox
    {
        public int[] MinOperations(string boxes)
        {
            int[] res = new int[boxes.Length];

            for (int j = 0; j < boxes.Length; j++)
            {

                res[j] = boxes.ToArray()
                    .Select((v, i) => v == '1' && i != j ? (i < j ? Math.Abs(i - j) : i - j) : -1)
                    .Where(x => x != -1)
                    .ToArray().Sum();


                //int[] indices = boxes.ToArray().Select((v, i) => v == '1' ? i : -1).Where(x => x != -1 && x != j).ToArray();
                //var distances = indices.Select(x => x < j ? Math.Abs(x - j) : x - j).ToArray();

                //res[j] = distances.Sum();
            }

            return res;
        }
    }
}
