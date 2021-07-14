using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 89)
            {
                if ((number % 10) > (number  / 10))
                {
                    Console.Write("{0:d2}, ", number);
                }
                number++;
            }
            Console.WriteLine(number);
        }
    }
}
