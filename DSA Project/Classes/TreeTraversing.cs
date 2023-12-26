using System.Collections.Generic;

namespace DSA_Project
{
  
   public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // Root of Binary Tree
        public Node root;

        public BinaryTree() { root = null; }

        public List<int> PreorderTraversal()
        {
            List<int> result = new List<int>();
            PreorderTraversalRecursive(root, result);
            return result;
        }

        private void PreorderTraversalRecursive(Node node, List<int> result)
        {
            if (node == null)
                return;

            result.Add(node.key);

            PreorderTraversalRecursive(node.left, result);

            PreorderTraversalRecursive(node.right, result);
        }


        // Post-Order

        public List<int> PostorderTraversal()
        {
            List<int> result = new List<int>();
            PostorderTraversalRecursive(root, result);
            return result;
        }

        private void PostorderTraversalRecursive(Node node, List<int> result)
        {
            if (node == null)
                return;

            PostorderTraversalRecursive(node.left, result);
            PostorderTraversalRecursive(node.right, result);
            result.Add(node.key);
        }


        //In-order

        public List<int> IntorderTraversal()
        {
            List<int> result = new List<int>();
            IntorderTraversalRecursive(root, result);
            return result;
        }

        private void IntorderTraversalRecursive(Node node, List<int> result)
        {
            if (node == null)
                return;

            IntorderTraversalRecursive(node.left, result);
            result.Add(node.key);
            IntorderTraversalRecursive(node.right, result);
        }

    }


}
