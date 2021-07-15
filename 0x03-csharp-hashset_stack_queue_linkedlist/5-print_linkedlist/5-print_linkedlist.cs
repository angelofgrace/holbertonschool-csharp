using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newList = new LinkedList<int>();
        
        if (size < 0)
        {
            return (newList);
        }

        for (int x = 0; x < size; x++)
        {
            newList.AddLast(x);
            Console.WriteLine(x);
        }

        return (newList);

    }
}