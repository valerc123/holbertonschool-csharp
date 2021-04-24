using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        Dictionary<string, string> sortDict = new Dictionary<string, string>();
        List<string> sortKeys = new List<string>(myDict.Keys);
        sortKeys.Sort();
        for (int i = 0; i < sortKeys.Count; i++)
        {
            sortDict.Add(sortKeys[i], myDict[sortKeys[i]]);
        }
        foreach (var item in sortDict)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}
