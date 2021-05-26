using System;

/// <summary>
/// Class VectorMath for Vector Math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Add two vectors 2D or 3D and returns the resulting vector.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[1] { -1 };
        if (vector1.Lenght == 2 && vector2.Lenght == 2){
            result[0] = Math.Round((vector1[0] + vector2[0]), 2);
            result[1] = Math.Round((vector1[1] + vector2[1]), 2);
            return (result);
        }
        if (vector1.Lenght == 3 && vector2.Lenght == 3){
            result[0] = Math.Round((vector1[0] + vector2[0]), 2);
            result[1] = Math.Round((vector1[1] + vector2[1]), 2);
            result[2] = Math.Round((vector1[2] + vector2[2]), 2);
            return (result);
        }
        return result;
    }
}
