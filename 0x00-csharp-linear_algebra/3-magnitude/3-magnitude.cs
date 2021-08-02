using System;
using System.Collections.Generic;

/// <summary> Vector Math class </summary>
class VectorMath
{
    /// <summary> Script to calculate the magnitude of any 2 or 3D vector </summary>
    public static double Magnitude(double[] vector)
    {
        double givenSides = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return (-1);
        }
        foreach (double number in vector)
        {
            givenSides = givenSides + (number * number);
        }
        return Math.Round(Math.Sqrt(givenSides), 2);
    }
}
