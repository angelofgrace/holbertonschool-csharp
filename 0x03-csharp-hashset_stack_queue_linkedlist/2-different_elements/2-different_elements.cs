using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // short of writing an entire binary search algo, 
        // given the library and method limitations,
        // this is as efficient as it gets in 15 minutes of code

        List<int> distinctList = new List<int>();
        List<int> commonList = new List<int>();

        foreach (int element in list1)
        {
            if (list2.Contains(element) != true)
            {
                distinctList.Add(element);
            }
            else
            {
                commonList.Add(element);
            }
        }
        foreach (int element in list2)
        {
            if (commonList.Contains(element) != true)
            {
                distinctList.Add(element);
            }
        }
        distinctList.Sort();
        return (distinctList);
    }
}