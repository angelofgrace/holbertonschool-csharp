using System;
using System.Collections.Generic;
using System.Linq;

/// <summary> Vector Math class </summary>
class VectorMath
{
    /// <summary> find the dot product of two vectors, either 2D or 3D </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int l1, l2;
        l1 = vector1.Length;
        l2 = vector2.Length;
        if (l1 < 2 || l1 > 3 || l2 < 2 || l2 > 3 || l1 != l2)
        {
            return (-1);
        }
        List<double> products = new List<double>();
        for (int x = 0; x < l1; x++)
        {
            products.Add(vector1[x] * vector2[x]);
        }
        double result = Convert.ToDouble(products.Sum);
        return result;
    }
}