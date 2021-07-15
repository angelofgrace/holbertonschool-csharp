using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> uniqueElements = new List<int>();
        int total = 0;

        foreach (int number in myList)
        {
            if (uniqueElements.Contains(number) != true)
            {
                uniqueElements.Add(number);
                total = total + number;
            }
        }
        return total;
    }
}