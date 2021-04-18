using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> sorted = new List<int>();

        for (int i = 0; i < list1.Count; i++)
        {
            if (!list2.Contains(list1[i])){
                sorted.Add(list1[i]);
            }
        }
        for (int j = 0; j < list2.Count; j++){

            if (!list1.Contains(list2[j])){
                sorted.Add(list2[j]);
            }
        }
        sorted.Sort();
        return sorted;
    }
}
