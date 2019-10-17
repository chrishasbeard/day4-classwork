using System;

namespace ForLoopDecriment
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOddNumbers(7);
        }
        public static void PrintOddNumbers(int number)
        {
            for(int i=number; 0<i; i--)
            {
                if(i %2 != 0)
                {
                    Console.WriteLine(i); // use i instead of number since the var i is the one donig all of the work/getting worked
                }
            }
        }
    }
}
