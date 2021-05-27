using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        /// <summary>
        /// method that multiplies a matrix and a scalar and returns the resulting matrix.
        /// </summary>
        double[,] result new double[,] { { -1 } };
        //double[,] errArr = new double[,] { { -1 } };

        if ((matrix.GetLength(0) == 2) && (matrix.GetLength(1) == 2))
            result = new double[2, 2];
        else if ((matrix.GetLength(0) == 3) && (matrix.GetLength(1) == 3))
            result = new double[3, 3];
        else
            return (result);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return (result);
    }
}
