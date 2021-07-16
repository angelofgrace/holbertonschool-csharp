using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;

        if (myLList.First == null)
        {
            myLList.AddFirst(n);
        }
        current = myLList.First;
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }
        if (current == myLList.First && current.Value > n)
        {
            myLList.AddFirst(n);
        }
        else
        {
            myLList.AddAfter(current, n);
        }
        current = current.Next;
        return (current);
    }
}