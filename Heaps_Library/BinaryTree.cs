using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps_Library
{
    public class BinaryTree
    {
        public Node? Root { get; set; }

        public Node buildBinaryTree(int[] arr, int i)
        {
            Node? next = null;

            if (i < arr.Length)
            {
                next = new Node(arr[i]);

                next.LeftNode = buildBinaryTree(arr, 2 * i + 1);

                next.RightNode = buildBinaryTree(arr, 2 * i + 2);

            }

            return next;
        }

        public void printNodeData(Node root)
        {
            if (root != null)
            {
                printNodeData(root.LeftNode);
                Console.Write(root.Data + " ");
                printNodeData(root.RightNode);
            }
        }
    }
}
