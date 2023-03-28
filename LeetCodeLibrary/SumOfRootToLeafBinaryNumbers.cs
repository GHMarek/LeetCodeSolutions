using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class SumOfRootToLeafBinaryNumbers
    {
        // After half an hour fight I used solution https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/solutions/2971989/if-leaf-then-number/?orderBy=hot&languageTags=csharp;
       
        
        List<List<int>> ls = new List<List<int>>();
        public int SumRootToLeaf(TreeNode root)
        {
            var ans = 0;
            DFS(root, new Stack<int>());

            foreach (var i in ls)
                for (var j = 0; j < i.Count; j++)
                    ans += i[j] * (int)Math.Pow(2, j);
            return ans;
        }
        public void DFS(TreeNode root, Stack<int> stack)
        {
            if (root == null) return;

            stack.Push(root.val);
            DFS(root.left, stack);
            DFS(root.right, stack);

            if (root.left == null && root.right == null)
                ls.Add(new List<int>(stack));
            if (stack.Count > 0) stack.Pop();
        }

    }
}
