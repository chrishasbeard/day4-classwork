using System;

namespace nested_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable(3);
        }
        public static void MultiplicationTable(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for(int j = 1; j <= number; j++)
                {
                    Console.Write($"\t{i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
