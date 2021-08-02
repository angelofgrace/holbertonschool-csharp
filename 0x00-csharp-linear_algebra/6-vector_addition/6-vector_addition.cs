using System;
using System.Collections.Generic;

/// <summary> Vector Math class </summary>
class VectorMath
{

    /// <summary> Add two vectors together </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int l1, l2;
        l1 = vector1.Length;
        l2 = vector2.Length;
        double[] sumVector = new double[l1];
        if (l1 > 3 || l1 < 2 || l2 > 3 || l2 < 2 || l1 != l2)
        {
            sumVector[0] = -1;
            return (sumVector);
        }
        
        for (int x = 0; x < l1; x++)
        {
            sumVector[x] = vector1[x] + vector2[x];
        }
        return sumVector;
    }
}