using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string phrase = "";
        if (number % 10 > 5)
        {
            phrase = "and is greater than 5";
        }
        else if (number == 0)
        {
            phrase = "and is 0";
        }
        else
        {
            phrase = "and is less than 6 and not 0";
        }
        Console.WriteLine("The last digit of {0} is {2} {1}", number.ToString(), phrase, (number % 10).ToString());
    }
}