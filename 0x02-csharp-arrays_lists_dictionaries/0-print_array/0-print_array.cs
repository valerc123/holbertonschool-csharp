using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] new_arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            new_arr[i] = i;
            Console.Write("{0}{1}", i, i == (size - 1) ? "" : " ");
        }
        Console.WriteLine();
        return new_arr;
    }
}
