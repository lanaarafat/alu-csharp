using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);

        if ((rows1 == 2 && (cols1 == 2 || cols1 == 3) && rows2 == 2 && (cols2 == 2 || cols2 == 3) && rows1 == rows2 && cols1 == cols2) ||
            (rows1 == 3 && cols1 == 3 && rows2 == 3 && cols2 == 3 && rows1 == rows2 && cols1 == cols2))
        {
            return new double[,] { { -1 }};
        }

        double[,] result = new double[rows1, cols1];

        for (int j = 0; j < cols1; j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }

        return result;
    }
}