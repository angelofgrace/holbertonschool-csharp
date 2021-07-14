﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        List<int> newList = new List<int>();

        for (int x = 0; x < size; x++)
        {
            newList.Add(x);
            if (x < size - 1)
            {
                Console.Write(newList[x] + " ");
            }
            else
            {
                Console.Write(newList[x]);
            }
        }
        Console.WriteLine("");
        return (newList);
    }
}