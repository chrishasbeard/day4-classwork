using System;

namespace class_code_challenge
{
    class Program
    {
        static int i,sum;
        static void Main(string[] args)
        {
            CountAllTheNumbers(5);
            Console.WriteLine(sum);
         
        }
        public static int CountAllTheNumbers(int number)
        {
           sum=0;
            for(int i = number; i > 0 ; i--)
            {
                sum = sum + i;                
            }
            return sum;
        }

    }
}
