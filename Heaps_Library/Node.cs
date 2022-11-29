using System.Security.Principal;

namespace Heaps_Library
{
    public class Node
    {
        public Node? LeftNode;

        public Node? RightNode;

        public int Data;

        public Node(int data) 
        {
            Data = data;
            LeftNode = null;
            RightNode = null;
        }
    }
}