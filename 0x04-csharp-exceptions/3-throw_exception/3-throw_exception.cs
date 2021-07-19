using System;

class Except
{
    public static void Throw()
    {
        if (true)
        {
            throw new Exception();
        }
    }
}