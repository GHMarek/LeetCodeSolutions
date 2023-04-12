using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FlippingAnImage
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {

            List<int[]> res = new List<int[]>() { };

            for (int i = 0; i < image.Length; i++)
            {
                res.Add(image[i].Reverse().ToArray());

                for (int j = 0; j < image[0].Length; j++)
                {
                    res[i][j] = 1 - res[i][j];
                }
            }

            return res.ToArray();
        }
    }
}
