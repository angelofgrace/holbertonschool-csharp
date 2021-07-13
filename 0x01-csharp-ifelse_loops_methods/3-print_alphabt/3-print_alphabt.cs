using System;

namespace _3_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            for (letter = 'a'; letter <= 'z'; letter ++)
            {
                if (letter == 'q' || letter == 'e')
                {
                    continue;
                }
                {
                    Console.Write(letter);
                }
            }
        }
    }
}