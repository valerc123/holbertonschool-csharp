using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5];
        matrix[2, 2] = 1;
        for (int col = 0; col < 5; col++)
        {
            for (int row = 0; row < 5; row++)
            {
                Console.Write("{0}{1}", matrix[col, row], row == 4 ? "\n": " ");
            }
        }
    }
}
