using System;

public abstract class Base
{
    public string name;

    public override ToString()
    {
        return String.Format("{} is a {}", name, typof(name));
    }
}