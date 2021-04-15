using System;

class Program
{
    static void Main(string[] args)
    {
        int [][] jagged = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };
        for (int x = 0; x < jagged.Length; x++) {
            for (int y = 0; y < jagged[x].Length; y++) {
                Console.Write("{0}{1}", jagged[x][y], y == (jagged[x].Length -1) ? "" : " ");
            }
            Console.WriteLine();
        }
    }
}