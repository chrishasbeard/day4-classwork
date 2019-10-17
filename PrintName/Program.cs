using System;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("bart", 4);
        }
        public static void PrintName(string userName, int number)
        {
            do
            {
                Console.WriteLine("Hello, "+ userName);
                number--;
            }
            while (number>0);
        }
    }
}
