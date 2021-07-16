using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < myLList.Count && index > 0)
        {
        int find = myLList.ElementAt(index);
        myLList.Remove(find);
        }
    }
}