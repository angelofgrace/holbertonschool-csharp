using System;

/// <summary> abstract class for general structure of derived classes </summary>
public abstract class Base
{
    /// <summary> defining title of an instance </summary>
    public string name
    {
        get;
        set;
    }

    /// <summary> basic ToString override </summary>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType().Name);
    }
}

/// <summary> interactivity indicator </summary>
public interface IInteractive
{
    /// <summary> method of interaction </summary>
    void Interact();
}

/// <summary> breakability indicator </summary>
public interface IBreakable
{
    /// <summary> durability </summary>
    int durability
    {
        get;
        set;
    }
    /// <summary> breaking point </summary>
    void Break();
}

/// <summary> collectibility indicator </summary>
public interface ICollectable
{
    /// <summary> some people got it </summary>
    bool isCollected
    {
        get;
        set;
    }
    /// <summary> do you got it </summary>
    void Collect();
}

/// <summary> Makings of a doorway </summary>
public class Door: Base, IInteractive
{
    /// <summary> build a door </summary>
    public Door(string doorName)
    {
       this.name = doorName;
    }

    /// <summary> Door interactions </summary>
    public void Interact() 
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}