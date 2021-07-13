using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        string phrase = "";
        if (number > 0)
        {
            phrase = "is positive";
        }
        else if (number < 0)
        {
            phrase = "is negative";
        }
        else
        {
            phrase = "is zero";
        }
        Console.WriteLine("{0} {1}", number, phrase);
    }
}
