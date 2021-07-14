using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int height, width;
        for (height = 0; height < length; height++)
        {
            for (width = 0; width < height; width++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        Console.WriteLine("");
    }
}