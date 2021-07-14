using System;

class Line
{
    public static void PrintLine(int length)
    {
        int iter = 0;
        while (iter < length)
        {
            Console.Write("_");
            iter++;
        }
        Console.WriteLine("");
    }
}