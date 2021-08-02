using System;
using System.Collections.Generic;

/// <summary> Vector Math Class </summary>
class VectorMath
{
    /// <summary> Multiply a vector of 2 or 3 dimensions by a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] productVector = new double[vector.Length];
        if (vector.Length > 3 || vector.Length < 2)
        {
            productVector[0] = -1;
            return productVector;
        }
        else if (vector.Length == 0)
        {
            double[] zeroVector = new double[1];
            zeroVector[0] = -1;
            return zeroVector;
        }
        for (int x = 0; x < vector.Length; x++)
        {
            productVector[x] = vector[x] * scalar;
        }
        return productVector;
    }
}