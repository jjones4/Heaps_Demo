using Heaps_Library;

namespace Heaps_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // STEP 1

            /*
             * 
             * Set up some random data in an array.
             * 
             * Create the array with a length of 10,
             * and fill it with random numbers from 10 to 50.
             * 
            */
            Random rnd = new Random();
            int[] data = new int[10];

            Console.Write("   Our initial data array is: ");
            
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(40) + 10;
                Console.Write($"{data[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // STEP 2

            /*
             * 
             * Create a binary tree from the array data.
             * 
            */
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Root = binaryTree.buildBinaryTree(data, 0);

            // Check to make sure our binary tree has all the data
            Console.WriteLine("   Our binary tree is:\n");

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"                  {binaryTree.Root.Data}");
                    Console.WriteLine("                 /  \\");
                }
                if (i == 1)
                {
                    Console.WriteLine($"           {binaryTree.Root.LeftNode.Data}            {binaryTree.Root.RightNode.Data}");
                    Console.WriteLine("          /  \\          /  \\");
                }
                if (i == 2)
                {
                    Console.WriteLine($"       {binaryTree.Root.LeftNode.LeftNode.Data}      {binaryTree.Root.LeftNode.RightNode.Data}     {binaryTree.Root.RightNode.LeftNode.Data}    {binaryTree.Root.RightNode.RightNode.Data}");
                    Console.WriteLine("      /  \\    /  \\   /  \\  /  \\");

                }
                if (i == 3)
                {
                    Console.WriteLine($"     {binaryTree.Root.LeftNode.LeftNode.LeftNode.Data}  {binaryTree.Root.LeftNode.LeftNode.RightNode.Data}  {binaryTree.Root.LeftNode.RightNode.LeftNode.Data}");

                }
            }

            Console.WriteLine();

            // STEP 3

            /*
             * 
             * Heapify the binary tree (max-heap).
             * 
            */
            Console.WriteLine("   After heapify, our binary tree is:\n");

            binaryTree.heapifyTree(binaryTree.Root);

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"                  {binaryTree.Root.Data}");
                    Console.WriteLine("                 /  \\");
                }
                if (i == 1)
                {
                    Console.WriteLine($"           {binaryTree.Root.LeftNode.Data}            {binaryTree.Root.RightNode.Data}");
                    Console.WriteLine("          /  \\          /  \\");
                }
                if (i == 2)
                {
                    Console.WriteLine($"       {binaryTree.Root.LeftNode.LeftNode.Data}      {binaryTree.Root.LeftNode.RightNode.Data}     {binaryTree.Root.RightNode.LeftNode.Data}    {binaryTree.Root.RightNode.RightNode.Data}");
                    Console.WriteLine("      /  \\    /  \\   /  \\  /  \\");

                }
                if (i == 3)
                {
                    Console.WriteLine($"     {binaryTree.Root.LeftNode.LeftNode.LeftNode.Data}  {binaryTree.Root.LeftNode.LeftNode.RightNode.Data}  {binaryTree.Root.LeftNode.RightNode.LeftNode.Data}");

                }
            }

            Console.WriteLine();
        }
    }
}
