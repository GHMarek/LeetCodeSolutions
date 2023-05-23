using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DeepestLeavesSum
    {
        public int DeepestLeavesSumm(TreeNode root)
        {

            int deepestLevel = 0;
            int sumLeaves = root.val;
            int level = 0;

            //InOrderTrav(root);

            return sumLeaves;
        }

        public void InOrderTrav(TreeNode root, ref int level, ref int deepestLevel, ref int sumLeaves)
        {

            if (root == null)
            {
                sumLeaves += 0;
            }

            if (root.left == null && root.right == null)
            {
                sumLeaves += 0;
            }

            if (root.left != null)
            {
                level += 1;

                if (level > deepestLevel)
                {
                    deepestLevel = level;
                    sumLeaves += root.val;
                    InOrderTrav(root.left, ref level, ref deepestLevel, ref sumLeaves);
                }
            }

            if (root.right != null)
            {
                level += 1;

                if (level > deepestLevel)
                {
                    deepestLevel = level;
                    sumLeaves += root.val;
                    InOrderTrav(root.right, ref level, ref deepestLevel, ref sumLeaves);
                }
            }
        }


    }
}
