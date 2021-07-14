using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int pop = 1;
            while (pop <= 100)
            {
                if (pop % 15 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (pop % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (pop % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write("{0} ", pop);
                }
                pop++;
            }
            Console.WriteLine("");
        }
    }
}