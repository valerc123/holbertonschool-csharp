using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int big = 0;
        string key_big = "";
        if (myList.Count == 0)
        {
            return "None";
        }else {
            foreach (var item in myList)
            {
                if (item.Value > big){
                    big = item.Value;
                    key_big = item.Key;
                }else{
                    continue;
                }
            }
            return key_big;
        }
    }
}
