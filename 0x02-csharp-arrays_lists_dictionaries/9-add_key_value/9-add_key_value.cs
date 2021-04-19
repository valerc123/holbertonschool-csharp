﻿using System;

class Dictionary
{
   public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (!myDict.ContainsKey(key)){
            myDict.Add(key, value);
            return myDict;
        }
        else {
            myDict[key] = value;
            return myDict;
        }
    }
}
