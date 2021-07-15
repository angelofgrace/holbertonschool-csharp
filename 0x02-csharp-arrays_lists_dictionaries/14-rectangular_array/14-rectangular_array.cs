using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            int [,] multiDimensional = new int [5,5]
            {
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0}
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4)
                    {
                        Console.Write(multiDimensional[i,j] + " ");
                    }
                    else
                    {
                        Console.Write(multiDimensional[i,j]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }