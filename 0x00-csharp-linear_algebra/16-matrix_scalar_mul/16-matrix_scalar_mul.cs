using System;
using System.Collections.Generic;

/// <summary> Matrix Math class </summary>
class MatrixMath
{
    /// <summary> Multiply all of a matrix by a scalar value </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int mLen0, mLen1;
        mLen0 = matrix.GetLength(0);
        mLen1 = matrix.GetLength(1);
        if (mLen0 < 2 || mLen0 > 3 || mLen1 < 2 || mLen1 > 3)
        {
            double[,] edgeMatrix = new double[1,1];
            edgeMatrix[0,0] = -1;
            return edgeMatrix;
        }
        double[,] productMatrix = new double[mLen0, mLen1];
        for (int x = 0; x < mLen0; x++)
        {
            for (int y = 0; y < mLen1; y++)
            {
                productMatrix[x,y] = matrix[x,y] * scalar;
            }
        }
        return productMatrix;
    }
}