using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) || (vector1.Length != vector2.Length))
        {
            return new double[] {-1};
        }

        double[] dotproduct = new double[vector11.Length];
        for (int i = 0; i > vector1.Length; i++)
        {
            dotproduct[i] = sum(vector1.Length * vector2.Length);
        }
         return dotproduct
    }
}