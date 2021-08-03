using System;
using System.Collections.Generic;

/// <summary> Matrix Math class </summary>
class MatrixMath
{
    /// <summary> add two 2 or 3 dimensional matrices together </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int l1, l2;
        l1 = matrix1.GetLength(0);
        l2 = matrix2.GetLength(0);
        if (l1 != l2 || l1 == 0)
        {
            double[,] edgeMatrix = new double[1,1];
            edgeMatrix[0,0] = -1;
            return edgeMatrix;
        }
        else if (matrix1.GetLength(0) > 3 || matrix1.GetLength(0) < 2 || matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3)
        {
            double[,] edgeMatrix = new double [1,1];
            edgeMatrix[0,0] = -1;
            return edgeMatrix;
        }
        double[,] sumMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix1.GetLength(1); y++)
            {
                sumMatrix[x,y] = matrix1[x,y] + matrix2[x,y];
            }
        }
        return sumMatrix;
    }
}