using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);

        int[,] newMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int tmp = Convert.ToInt32(myMatrix[i,j]);
                double result = (Math.Pow(tmp, 2));
                int tmpSqr = Convert.ToInt32(result);
                newMatrix.SetValue(tmpSqr, i, j);
            }
        }
        
        return (newMatrix);
    }
}
