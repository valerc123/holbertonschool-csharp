using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        int[] unique = myList.Distinct().ToArray();
        foreach(int num in unique){
            sum = sum + num;
        }
        return sum;
    }
}
