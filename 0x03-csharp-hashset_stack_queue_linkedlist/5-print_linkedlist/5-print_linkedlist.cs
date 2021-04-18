using System;
using System.Collections;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> new_linkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            new_linkedList.AddLast(i);
            Console.WriteLine(i);
        }
        return new_linkedList;
    }
}
