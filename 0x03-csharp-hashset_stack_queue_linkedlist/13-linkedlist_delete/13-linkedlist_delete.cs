using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int find = myLList.ElementAt(index);
        myLList.Remove(find);
    }
}