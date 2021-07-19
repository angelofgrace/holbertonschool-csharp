using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        for (int x = 0; x < listLength; x++)
        {
            try
            {
                result.Add(list1[x] / list2[x]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                result.Add(0);
                Console.WriteLine("Cannot divide by zero");
            }
        }
        return (result);
    }
}