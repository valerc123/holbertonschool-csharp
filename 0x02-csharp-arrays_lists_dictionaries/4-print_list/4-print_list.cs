using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> new_list = new List<int>(size);
        if (size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if(size == 0){
            Console.WriteLine();
        }
        else{
            for (int i = 0; i < size; i++)
            {
                new_list.Add(i);
                Console.Write("{0}{1}", i, i < size -1 ? " " : "\n");
            }
        }
        return new_list;
    }
}
