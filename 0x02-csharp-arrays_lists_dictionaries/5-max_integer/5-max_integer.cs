using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = 0;
        if (myList.Count == 0){
            Console.WriteLine("List is empty");
            return (-1);
        }else {
            foreach (var item in myList)
            {
                if (max<item){
                    max = item;
                }
            }
        }
        return max;
    }
}
