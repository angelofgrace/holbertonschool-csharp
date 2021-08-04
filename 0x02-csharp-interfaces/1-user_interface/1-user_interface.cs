using System;

/// <summary> abstract class for general structure of derived classes </summary>
public abstract class Base
{
    /// <summary> defining title of an instance </summary>
    public string name;

    /// <summary> basic ToString override </summary>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType().Name);
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
}

/// <summary> Testing 1.. 2.. 3.. 4.. </summary>
public class TestObject : Base
{
    /// <summary> can  you hear me now </summary>
    public TestObject() {}

    public int durability {get; set;}
    public bool isCollected {get; set;}

    public void Collect() {}
    public void Break() {}
    public void Interact() {}
}

