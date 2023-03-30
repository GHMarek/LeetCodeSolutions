using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public  class FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            return edges[0].Intersect(edges[1]).Intersect(edges[2]).FirstOrDefault();
        }
    }
}
