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
        void Interact();
    }

    /// <summary> breakability indicator </summary>
    public interface IBreakable
    {
        int durabilility
        {
            get;
            set;
        }
        void Break();
    }

    /// <summary> collectibility indicator </summary>
    public interface ICollectable
    {
        bool isCollected
        {
            get;
            set;
        }
        void Collect();
    }
}

/// <summary> Testing 1.. 2.. 3.. 4.. </summary>
public class TestObject : Base
{
    public TestObject() {}
}

