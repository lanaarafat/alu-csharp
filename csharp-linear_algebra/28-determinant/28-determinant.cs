using System;

class MatrixMath
{
 public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        if ((rows != 2 && cols != 2) || (rows != 3 && cols != 3))
        {
            return -1;
        }

        // determinant for 2x2 matrix
        if (rows == 2 && cols == 2)
        {
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[1, 0];
            double d = matrix[1, 1];
            return Math.Round(a * d - b * c,2);
        }

        // determinant for 3x3 matrix
        else if (rows == 3 && cols == 3)
        {
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 0];
            double e = matrix[1, 1];
            double f = matrix[1, 2];
            double g = matrix[2, 0];
            double h = matrix[2, 1];
            double i = matrix[2, 2];

            double determinant = a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
            return Math.Round(determinant, 2);
        }

        return -1;
    }
}