using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        for (int x = 0; x < n; x++)
        {
            try
            {
                Console.WriteLine(myList[x]);
            }
            catch (ArgumentOutOfRangeException)
            {
                return (x);
            }
        }
        return (n);
    }
}