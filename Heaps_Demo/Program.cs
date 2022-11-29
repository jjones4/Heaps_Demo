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
             * Make the array a random length from 0 to 19,
             * and fill it with random numbers from 0 to 19.
             * 
            */
            Random rnd = new Random();

            int numberOfNodes = rnd.Next(20);

            Console.WriteLine($"   The length of our data is: {numberOfNodes}\n");

            Console.Write("   Our initial data array is: [ ");

            int[] data = new int[numberOfNodes];

            for (int i = 0; i < numberOfNodes; i++)
            {
                data[i] = rnd.Next(20);

                Console.Write($"{data[i]} ");
            }

            Console.Write("]");

            Console.WriteLine();

            // STEP 2

            /*
             * 
             * Create our binary tree from the array data.
             * 
            */
        }
    }
}