using System;
using System.Collections.Generic;

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
    /// INEFFICIENT CODE , HARD CODED "DOOR" SHOULD BE DYNAMIC
    public Door(string doorName = "Door")
    {
       this.name = doorName;
    }

    /// <summary> Door interactions </summary>
    public void Interact() 
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}

/// <summary> Interior Decoration </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> should you care </summary>
    public bool isQuestItem;
    /// <summary> durability </summary>
    public int durability {get; set;}

    /// <summary> make me an object </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> Interact with decorations </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        }
        else
        {
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
    }

    /// <summary> Break in case of desire to break </summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        else
        {
            Console.WriteLine("The {0} is already broken.", name);
        }

    }
}

/// <summary> Ring of keys </summary>
public class Key : Base, ICollectable
{
    /// <summary> do you have it yet </summary>
    public bool isCollected {get; set;}

    /// <summary> make me a key </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary> Add it to your collection </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
    }
}

class RoomObjects
{
    ///<summary>Use everything you found</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base object in roomObjects)
        {
            if (type == typeof(IInteractive) &&  object is IInteractive)
            {
                ((IInteractive)object).Interact();
            }
            if (type == typeof(IBreakable) &&  object is IBreakable)
            {
                ((IBreakable)object).Break();
            }
            if (type == typeof(ICollectable) &&  object is ICollectable)
            {
                ((ICollectable)object).Collect();
            }
        }
    }
}