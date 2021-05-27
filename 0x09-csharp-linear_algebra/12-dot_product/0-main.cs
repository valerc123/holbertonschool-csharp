using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = new double[3] {2, 2, -3};
        double[] vector2 = new double[3] {4, 1, -3};
   
        double result = VectorMath.DotProduct(vector1, vector2);
        Console.WriteLine("{0}", result);
    }
}
