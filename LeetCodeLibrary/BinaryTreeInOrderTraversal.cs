using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class BinaryTreeInOrderTraversal
    {
        // Types of traversal order https://pl.wikipedia.org/wiki/Przechodzenie_drzewa

        /*IN-ORDER(wierzchołek_v)
        {
        jeżeli wierzchołek_v.lewy_syn != null to IN-ORDER(wierzchołek_v.lewy_syn)
        wypisz wierzchołek_v.wartość
        jeżeli wierzchołek_v.prawy_syn != null to IN-ORDER(wierzchołek_v.prawy_syn)
        }
        */

        public IList<int> InorderTraversal(TreeNode root)
        {

            List<int> res = new List<int>();

            if (root == null)
            {
                return new List<int>() { };
            }

            if (root.left == null && root.right == null)
            {
                return new List<int>() { root.val };
            }

            // jeżeli wierzchołek_v.lewy_syn != null to IN-ORDER(wierzchołek_v.lewy_syn)
            if (root.left != null)
            {
                res.AddRange(InorderTraversal(root.left));
            }

            // wypisz wierzchołek_v.wartość
            if (root != null)
            {
                res.Add(root.val);
            }

            // jeżeli wierzchołek_v.prawy_syn != null to IN-ORDER(wierzchołek_v.prawy_syn)
            if (root.right != null)
            {
                res.AddRange(InorderTraversal(root.right));
            }

            return res;


        }


    }
}
