using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {2, 2, -3};
        double scalar = 0.5;
        double[] result = VectorMath.Multiply(vector, scalar);
        foreach (var item in result)
        {
            Console.WriteLine("{0}", item);
        }
    }
}
