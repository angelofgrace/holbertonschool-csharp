using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int rem;
        rem = number % 10;
        if (number < 0)
        {
            rem = rem * -1;
        }
        Console.Write(rem);
        return rem;
    }
}