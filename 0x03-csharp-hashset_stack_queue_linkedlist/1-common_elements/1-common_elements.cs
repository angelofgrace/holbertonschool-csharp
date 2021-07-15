using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonalityList = new List<int>();

        foreach (int element in list1)
        {
            if (list2.Contains(element))
            {
                commonalityList.Add(element);
            }
        }

        return (commonalityList);
    }
}