class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)

    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        double determinant = a * d - b * c;

        if (determinant == 0)
        {
            return new double[,] { { -1 } };
        }
        double[,] inverse = new double[2, 2];

        /* A ^−1 = 1/det(A)(d −b)
                           (−c a) */

        inverse[0, 0] = Math.Round(d / determinant, 2);
        inverse[0, 1] = Math.Round(-b / determinant, 2);
        inverse[1, 0] = Math.Round(-c / determinant, 2);
        inverse[1, 1] = Math.Round(a / determinant, 2);

        return inverse;
    }
}