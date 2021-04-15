using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index > array.Length -1 || index < 0){
            return array;
        }else{
            array[index] = n;
            return array;
        }
    }
}
