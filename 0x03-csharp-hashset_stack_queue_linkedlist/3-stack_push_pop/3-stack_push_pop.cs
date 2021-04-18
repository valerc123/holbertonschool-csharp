using System;
using System.Collections;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        if(aStack.Count == 0){
            Console.WriteLine("Stack is empty");
        }
        if(aStack.Contains(search)){
            Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search));
            aStack.Clear();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
