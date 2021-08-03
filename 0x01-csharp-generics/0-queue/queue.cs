using System;

/// <summary> Custom Queue class </summary>
class Queue<T>
{
    /// <summary> returns the type of an object </summary>
    public static Type CheckType(Queue<T> queue)
    {
        return queue.GetType();
    }
}