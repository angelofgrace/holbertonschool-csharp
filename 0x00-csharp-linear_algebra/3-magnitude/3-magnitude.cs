using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int givenSides = 0;
        if (vector.count < 2 || vector.count > 3)
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
