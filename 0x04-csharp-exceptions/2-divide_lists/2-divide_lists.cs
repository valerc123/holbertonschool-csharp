using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int divide = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                divide = list1[i] / list2[i];
                result.Add(divide);
            }
            catch (DivideByZeroException)
            {
                result.Add(0);
                Console.WriteLine("Cannot divide by zero");
            }
            catch(ArgumentOutOfRangeException){
                Console.WriteLine("Out of range");
            }
        }
        return result;
    }
}
