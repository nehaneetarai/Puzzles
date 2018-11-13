using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class TopViewBT
    {
        public static void TopViewMain(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.left.right.right = new TreeNode(5);
            root.left.right.right.right = new TreeNode(6);
            Tree t = new Tree(root);
            Console.WriteLine("Following are nodes in top view of Binary Tree");
            t.printTopView();
        }

        // Class for a tree node
        public class TreeNode
        {
            // Members
            public int key;
            public TreeNode left, right;

            // Constructor
            public TreeNode(int key)
            {
                this.key = key;
                left = right = null;
            }
        }

        // A class to represent a queue item. The queue is used to do Level
        // order traversal. Every Queue item contains node and horizontal
        // distance of node from root
        public class QItem
        {
            public TreeNode node;
            public int hd;
            public QItem(TreeNode n, int h)
            {
                node = n;
                hd = h;
            }
        }

        // Class for a Binary Tree
        public class Tree
        {
            public TreeNode root;

            // Constructors
            public Tree() { root = null; }
            public Tree(TreeNode n) { root = n; }

            // This method prints nodes in top view of binary tree
            public void printTopView()
            {
                // base case
                if (root == null) { return; }

                // Creates an empty hashset
                HashSet<int> set = new HashSet<int>();

                // Create a queue and add root to it
                Queue<QItem> Q = new Queue<QItem>();
                Q.Enqueue(new QItem(root, 0)); // Horizontal distance of root is 0

                // Standard BFS or level order traversal loop
                while (Q.Count != 0)
                {
                    // Remove the front item and get its details
                    QItem qi = Q.Dequeue();
                    int hd = qi.hd;
                    TreeNode n = qi.node;

                    // If this is the first node at its horizontal distance,
                    // then this node is in top view
                    if (!set.Contains(hd))
                    {
                        set.Add(hd);
                        Console.WriteLine(n.key + " ");
                    }

                    // Enqueue left and right children of current node
                    if (n.left != null)
                        Q.Enqueue(new QItem(n.left, hd - 1));
                    if (n.right != null)
                        Q.Enqueue(new QItem(n.right, hd + 1));
                }
            }
        }
    }
}
