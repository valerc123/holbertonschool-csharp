using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i = 0;
        foreach (var elem in myLList)
        {
            if(elem == value){
                return i;
            }
            i++;
        }
        return -1;
    }
}
