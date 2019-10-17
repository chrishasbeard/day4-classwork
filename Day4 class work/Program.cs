using System;

namespace Day4_class_work
{
    class Program
    {
        static int number;
        static void Main(string[] args)
        {
         SayHello(3);
        }
    public static void SayHello(int number)
        {
            while(true)
            {
                Console.WriteLine("Hello, while true");
                number--;
                if(number == 0)
                {
                    break;
                }
            }
        }
    }     
}
