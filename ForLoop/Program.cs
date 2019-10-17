using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("StEvE jObS", 4);
        }
        public static void PrintName(string userName, int number)
        {
            for (int i = 0; i < number; i++) 
            {
                Console.WriteLine("Hello, " + userName);
            }
        }
    }
}
