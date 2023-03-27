using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RangeSumOfBST
    {
        
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            int sum = 0;

            if (root == null)
            {
                return sum;
            }

            if (root.val >= low && root.val <= high)
            {
                sum += root.val;
            }

            if (root.val > low)
            {
                sum += RangeSumBST(root.left, low, high);
            }

            if (root.val < high)
            {
                sum += RangeSumBST(root.right, low, high);
            }


            return sum;
            
        }
    }
}
