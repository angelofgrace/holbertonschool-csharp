using System;

    class Program
    {
        static void Main(string[] args)
        {
            double percent = .7553;
            double currency = 98765.4321;
            Console.WriteLine("Percent: {0}", percent.ToString("P"));
            Console.WriteLine("Currency: {0}", String.Format("{0:C}", currency));
        }
    }