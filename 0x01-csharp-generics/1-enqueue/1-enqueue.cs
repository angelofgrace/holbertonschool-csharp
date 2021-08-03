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
        T value = default(T);
        Node next = null;

        public Node(T val = default(T))
        {
            value = val;
        }
    }

    public Node head;
    public Node tail;
    public int count = 0;

    public void Enqueue(T val)
    {
        Node newNode = new Node(val);
        if (count == 0)
        {
            head = newNode;
        }
        count += 1;
    }

    public int Count()
    {
        return count;
    }
}