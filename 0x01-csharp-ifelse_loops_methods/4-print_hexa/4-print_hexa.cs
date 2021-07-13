using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number <= 98)
            {
                Console.WriteLine("{0} = 0x{0:x}", number);
                number++;
            }
        }
    }
}
