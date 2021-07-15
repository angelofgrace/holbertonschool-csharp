﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // count the stack
        Console.WriteLine("Number of items: {0}", aStack.Count);

        // look at the top card of your library
        if (aStack == null)
        {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Top item: {0}", aStack.Peek());

        // search for a needle in the haySTACK
        bool found = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, found);
        if (found)
        {
            string check = "";
            while (check != search)
            {
                check = aStack.Pop();
            }
        }

        // add to the pile
        aStack.Push(newItem);
        return (aStack);
    }
}