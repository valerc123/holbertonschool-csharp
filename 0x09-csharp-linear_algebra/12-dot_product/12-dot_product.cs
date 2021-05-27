using System;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// This method calculate dot product of either two 2D or two 3D vectors. 
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == vector2.Length){
            if(vector1.Length == 2){
                double dotProduct = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
                return dotProduct;
            }
            else if(vector1.Length == 3){
                double dotProduct = (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
                return dotProduct;
            }
        }
        return -1;
    }
}
