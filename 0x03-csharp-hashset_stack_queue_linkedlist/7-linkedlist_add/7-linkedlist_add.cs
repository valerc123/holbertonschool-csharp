using System;
using System.Collections;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_node = new LinkedListNode<int>(n);

        myLList.AddFirst(n);
        return new_node;
    }
}
