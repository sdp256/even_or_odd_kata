using System;

namespace even_or_odd_kata
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            EvenOrOdd(number);
           
            


            ///number % 2 = 0 write even, else write odd
        }
        static string EvenOrOdd(int x)
        {
            
            if (x % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
           
        }



    }
}
