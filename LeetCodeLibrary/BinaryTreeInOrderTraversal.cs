using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class BinaryTreeInOrderTraversal
    {
        
        public IList<int> InorderTraversal(TreeNode root)
        {

            List<int> res = new List<int>();
            
            if (root != null)
            {
                res.Add(root.val);
            }

            if (root == null)
            {
                return new List<int>() { };
            }

            if (root.left != null)
            {
                res.AddRange(InorderTraversal(root.left));
            }

            if (root.left == null && root.right == null)
            {
                return new List<int>() { root.val};
            }



            if (root.right != null)
            {
                res.AddRange(InorderTraversal(root.right));
            }

            return res;

        }


    }
}
