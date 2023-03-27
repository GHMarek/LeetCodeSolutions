using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    //class Node1
    //{
    //    public int? value;
    //    public Node1 left;
    //    public Node1 right;

    //    public void show()
    //    {
    //        Console.Write("[");
    //        Console.Write(value);
    //        Console.Write("]");
    //    }
    //}

    //class BinaryTree
    //{
    //    //public Node root;

    //    public BinaryTree(int?[] arr)
    //    {
    //        root = BuildTree(arr, 0);
    //    }

    //    private Node BuildTree(int?[] arr, int index)
    //    {
    //        if (index >= arr.Length || arr[index] == null)
    //        {
    //            return null;
    //        }

    //        Node node = new Node(arr[index]);
    //        node.left = BuildTree(arr, 2 * index + 1);
    //        node.right = BuildTree(arr, 2 * index + 2);

    //        return node;
    //    }

    //    public void PrintInOrder()
    //    {
    //        Console.Write("In-order Traversal: ");
    //        InOrderTraversal(root);
    //        Console.WriteLine();
    //    }

    //    private void InOrderTraversal(Node node)
    //    {
    //        if (node != null)
    //        {
    //            InOrderTraversal(node.left);
    //            Console.Write(node.value + " ");
    //            InOrderTraversal(node.right);
    //        }
    //    }
    //}
}
