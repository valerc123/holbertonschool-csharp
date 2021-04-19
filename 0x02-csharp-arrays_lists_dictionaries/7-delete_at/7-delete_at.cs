using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        List<int> remove = new List<int>();
        if(index > myList.Count){
            Console.WriteLine("Index is out of range");
            return myList;
        }
        else {
           myList.Remove(myList[index]);
            return remove;
        }
    }
}
