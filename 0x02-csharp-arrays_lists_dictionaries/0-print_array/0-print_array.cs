using System;
using System.Collections.Generic;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        int[] newArray = new int[size];
        
        for (int x = 0; x < size; x++)
        {
            newArray[x] = x;
            if (x < size - 1)
            {
                Console.Write(newArray[x] + " ");
            }
            else
            {
                Console.Write(newArray[x]);
            }
        }
        Console.WriteLine("");
        return (newArray);
    }
}