using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class PartitioningIntoMinimumNumberOfDeciBinaryNumbers
    {
        public int MinPartitions(string n)
        {

            return n.Max() - '0';

            
        }
    }
}
