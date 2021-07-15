using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList.Contains(value) != true || myLList.Count == 0)
        {
            return (-1);
        }

        for (int x = 0; x < myLList.Count; x++)
        {
            if (myLList.ElementAt(x) == value)
            {
                return (x);
            }
        }

        return (-1);
    }
}