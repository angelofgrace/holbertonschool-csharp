using System;

/// <summary> Custom Queue class </summary>
class Queue<T>
{
    /// <summary> returns the type of an object </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> A node of a Linked List </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T val = default(T))
        {
            value = val;
        }
    }

    public Node head = null;
    public Node tail = null;
    public int count = 0;

    public void Enqueue(T val)
    {
        Node newNode = new Node(val);
        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count += 1;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
            T headValue = head.value;
            head = head.next;
            count -= 1;
            return headValue;
    }

    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;        

    }

    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node tmpNode = head;
            while (tmpNode.next != null)
            {
                Console.WriteLine(tmpNode.value);
                tmpNode = tmpNode.next;
            }
            Console.WriteLine(tail.value);
        }
    }

    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) == string || typeof(T) == char)
        {
            string catStr = ""
            Node tmpNode = head;
            while (tmpNode.next != null)
            (
                catStr = catStr + " " + tmpNode.value;
                tmpNode = tmpNode.next;
            )
            catStr = catStr + " " + tail.value;
            return catStr;
        }
        else
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }
    }

    public int Count()
    {
        return count;
    }
}