using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace DSA_Project
{
    public partial class FrmTree : Form
    {


        private List<TreeNode> nodes = new List<TreeNode>();
        TreeNode root = new TreeNode();
        List<int> preorderResult;      // Store all after traversing pre-Order
        List<int> InorderResult;       // Store all after traversing in-Order
        List<int> PostorderResult;     // Store all after traversing post-Order
        public FrmTree()
        {
            InitializeComponent();
            // Create Tree
            root = new TreeNode { X = 400, Y = 20, Data = 10 };
            TreeNode node1 = new TreeNode { X = 330, Y = 120, Data = 34 };
            TreeNode node2 = new TreeNode { X = 470, Y = 120, Data = 5 };


            // For Node1 childs
            TreeNode node3 = new TreeNode { X = 280, Y = 220, Data = 23 };
            TreeNode node4 = new TreeNode { X = 368, Y = 220, Data = 56 };

            // For node2 childs
            TreeNode node5 = new TreeNode { X = 430, Y = 220, Data = 78 };
            TreeNode node6 = new TreeNode { X = 520, Y = 220, Data = 12 };

            //For node3 childs
            TreeNode node7 = new TreeNode { X = 240, Y = 310, Data = 40 };

            // for node6 childs
            TreeNode node8 = new TreeNode { X = 470, Y = 310, Data = 99 };
            TreeNode node9 = new TreeNode { X = 560, Y = 310, Data = 2 };

            // for node8 childs
            TreeNode node10 = new TreeNode { X = 425, Y = 390, Data = 19 };


            root.Children.Add(node1);
            root.Children.Add(node2);
            node1.Children.Add(node3);
            node1.Children.Add(node4);
            node2.Children.Add(node5);
            node2.Children.Add(node6);
            node3.Children.Add(node7);
            node6.Children.Add(node8);
            node6.Children.Add(node9);
            node8.Children.Add(node10);

            // Connect nodes to the tree 
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(root.Data);
            tree.root.left = new Node(node1.Data);
            tree.root.right = new Node(node2.Data);
            tree.root.left.left = new Node(node3.Data);
            tree.root.left.right = new Node(node4.Data);
            tree.root.right.left = new Node(node5.Data);
            tree.root.right.right = new Node(node6.Data);
            tree.root.left.left.left = new Node(node7.Data);
            tree.root.right.right.left = new Node(node8.Data);
            tree.root.right.right.right = new Node(node9.Data);
            tree.root.right.right.left.right = new Node(node8.Data);


            preorderResult = tree.PreorderTraversal();
            InorderResult = tree.IntorderTraversal();
            PostorderResult = tree.PostorderTraversal();

        }


        // Draw tree on PicBOx
        private void picTreeDesign_Paint(object sender, PaintEventArgs e)

        {
            if (root != null)
            {
                root.DrawNode(e.Graphics, 20);
            }
        }




        //Btn Find click
        private void btnFind_Click(object sender, EventArgs e)
        {
            
            if (selectTraversing.Text == "Pre-Order Traversing")
            {
                TraverName.Text = ("Pre-Order Traversing");

                List<string> result = new List<string>(); // Store result in list of string
                foreach (int value in preorderResult)
                {

                    result.Add(" " + value);
                }

                resultBox.Text = string.Join("", result);
                
            }


            else if (selectTraversing.Text == "In-Order Traversing")
            {
                TraverName.Text = ("In-Order Traversing");

                List<string> result = new List<string>(); // Store result in list of string
                foreach (int value in InorderResult)
                {

                    result.Add(" " + value);
                }

                resultBox.Text = string.Join("", result);
            }


            else if (selectTraversing.Text == "Post-Order Traversing")
            {
                TraverName.Text = ("Post-Order Traversing");

                List<string> result = new List<string>(); // Store result in list of string
                foreach (int value in PostorderResult)
                {
                    result.Add(" " + value);
                }

                resultBox.Text = string.Join("", result);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt_num = txtSearchNode.Text;
            int search_num = Int32.Parse(txt_num);

            bool Track = false;
            foreach(int value in PostorderResult)
            {
                if(search_num == value)
                {
                    Track = true;
                }
            }

            if (Track)
            {
                resultBox.Text = search_num + " is found in Tree";
            }
            else
            {
                resultBox.Text = search_num + " is not found in Tree";
            }
        }

    }
}


