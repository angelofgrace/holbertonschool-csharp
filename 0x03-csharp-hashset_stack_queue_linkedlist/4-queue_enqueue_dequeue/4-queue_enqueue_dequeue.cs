using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // count the queue
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        // print the top of the queue
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }

        // add to the queue
        aQueue.Enqueue(newItem);

        // peruse (search) the queue
        bool found;
        if (aQueue.Count == 0)
        {
            found = false;
        }
        else
        {
            found = aQueue.Contains(search);
        }
        Console.WriteLine("Queue contains {0}: {1}", search, found);

        if (found)
        {
            string check = "";
            while (check != search)
            {
                check = aQueue.Dequeue();
            }
        }

        return (aQueue);
    }

}