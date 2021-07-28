using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matrix2 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        double[,] result = MatrixMath.Add(matrix1, matrix2);
        foreach (var item in result)
        {
            Console.WriteLine("{0}", item);
        }
    }
}
