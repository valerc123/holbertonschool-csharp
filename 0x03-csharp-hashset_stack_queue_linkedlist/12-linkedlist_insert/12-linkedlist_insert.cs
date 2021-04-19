using System;
using System.Collections;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_node = new LinkedListNode<int>(n);
        int value = n;
        LinkedListNode<int> node = myLList.Find(16);
        myLList.AddAfter(node, n);
        
        return new_node;
    }
}
