using System;

/// <summary>
/// Vector Math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// This method multiply a vector and a scalar and returns the resulting vector.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[1] { -1 };
        if (vector.Length == 2){
            result = new double[2] {vector[0] * scalar, vector[1] * scalar};
            return (result);
        }
        else if (vector.Length == 3)
        {
            result = new double[3] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
            return (result);
        }

        return (result);
    }
}
