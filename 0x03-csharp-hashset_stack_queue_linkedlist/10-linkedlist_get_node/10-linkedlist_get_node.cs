﻿using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= myLList.Count)
        {
            return (0);
        }
        return (myLList.ElementAt(n));
    }
}