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
}