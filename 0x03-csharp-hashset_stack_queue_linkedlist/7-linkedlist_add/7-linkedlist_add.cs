using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(n);
        return (myLList);
    }
}
