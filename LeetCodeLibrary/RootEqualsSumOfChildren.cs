using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RootEqualsSumOfChildren
    {
        public bool CheckTree(TreeNode root)
        {

            if(root.val == root.left.val + root.right.val)
            {
                return true;
            }


            return false;


        }
    }
}
