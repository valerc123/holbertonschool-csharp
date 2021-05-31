﻿using System;

class MatrixMath 
{
    /// <summary>Function to find the determinant</summary>
    /// <param name="matrix">the matrix</param>
    /// <returns>the determinant or -1 if fail</returns>
    public static double Determinant(double[,] matrix) {
        double deter = 0;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) {
            deter = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
            return(deter);
        } else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3) {
            deter = Math.Round((matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))), 2);
            return(deter);
        } else
            return -1;
    }
}