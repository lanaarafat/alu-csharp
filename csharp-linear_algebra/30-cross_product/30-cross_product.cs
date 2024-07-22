using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if( vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] { -1 };
        }
        double a1 = vector1[0];
        double a2 = vector1[1];
        double a3 = vector1[2];
        double b1 = vector2[0];
        double b2 = vector2[1];
        double b3 = vector2[2];

        double[] crossProduct = new double[3];
        crossProduct[0] = a2 * b3 - a3 * b2;
        crossProduct[1] = a3 * b1 - a1 * b3;
        crossProduct[2] = a1 * b2 - a2 * b1;

        return crossProduct;
    }
}