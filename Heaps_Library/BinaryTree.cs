using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public void viewNodeData(Node root)
        {
            if (root != null)
            {
                viewNodeData(root.LeftNode);

                Console.Write(root.Data + " ");

                viewNodeData(root.RightNode);
            }
        }

        public void heapifyTree(Node root)
        {
            if (root != null)
            {
                heapifyTree(root.LeftNode);

                heapifyTree(root.RightNode);

                if (root.LeftNode == null && root.RightNode == null)
                {
                    return;
                }
                else if (root.LeftNode != null && root.RightNode == null)
                {
                    if (root.Data >= root.LeftNode.Data)
                    {
                        return;
                    }
                    else
                    {
                        int temp = root.Data;
                        root.Data = root.LeftNode.Data;
                        root.LeftNode.Data = temp;

                        heapifyTree(root);
                    }
                }
                else if (root.LeftNode != null & root.RightNode != null)
                {
                    if (root.Data >= root.LeftNode.Data && root.Data >= root.RightNode.Data)
                    {
                        return;
                    }

                    if (root.LeftNode.Data > root.RightNode.Data)
                    {
                        int temp = root.Data;
                        root.Data = root.LeftNode.Data;
                        root.LeftNode.Data = temp;

                        heapifyTree(root);
                    }
                    else if (root.LeftNode.Data <= root.RightNode.Data)
                    {
                        int temp = root.Data;
                        root.Data = root.RightNode.Data;
                        root.RightNode.Data = temp;

                        heapifyTree(root);
                    }
                }
            }
        }
    }
}
