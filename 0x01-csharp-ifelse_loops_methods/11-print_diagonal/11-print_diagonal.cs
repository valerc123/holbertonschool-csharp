using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if(length <= 0){
            Console.WriteLine();
        }else{
            for (int slash = 1; slash <= length; slash++)
            {
                for (int spaces = 0; spaces < slash; spaces++){
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
            Console.WriteLine();
        }
    }
}
