using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 99)
            {
                Console.Write("{0:d2}, ", number);
                number++;
            }
            Console.Write("{0}", number);
        }
    }