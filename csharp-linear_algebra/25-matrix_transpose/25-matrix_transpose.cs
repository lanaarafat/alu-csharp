using System;

class MatrixMath
{
public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols == 0)
        {
            return new double[0, 0];
        }
        
        double[,] resultMatrix = new double[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[j, i] = matrix[i, j];
            }
        }

        return resultMatrix;
    }
}