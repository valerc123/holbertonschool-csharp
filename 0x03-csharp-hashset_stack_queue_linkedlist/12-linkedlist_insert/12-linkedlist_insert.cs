using System;
using System.Collections;
using System.Collections.Generic;

class LList
{
  public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
     //   LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current;
        LinkedListNode<int> test ;
        current = myLList.First;
        while (current != null)
        {
            if (current.Value < n)
            {
                current = current.Next;
            }
            else
            {
               test = myLList.AddBefore(current, n);
                return test;
            }
        }
        return test;//  (myLList.AddBefore(current, n));
    }
}