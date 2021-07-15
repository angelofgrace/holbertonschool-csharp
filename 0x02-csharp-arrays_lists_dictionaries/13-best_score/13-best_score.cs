using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Values.Count == 0)
        {
            return ("None");
        }
        List<KeyValuePair<string, int>> itemList = new List<KeyValuePair<string, int>>(myList);
        itemList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
        return (itemList[itemList.Count - 1].Key);
    }
}