using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> results = new Dictionary<string, int>(myDict);

        foreach (string key in myDict.Keys)
        {
            results[key] = (results[key] * 2);
        }

        return (results);
    }
}