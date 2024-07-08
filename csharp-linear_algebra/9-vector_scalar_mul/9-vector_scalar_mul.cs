using System;

class VectorMath
{
  public static double[] Multiply(double[] vector, double scalar)
  {
    // Check if vector is 2D or 3D
    if (vector.Length != 2 && vector.Length != 3)
    {
      return new double[] { -1 }; // Return error vector
    }

    // Create a new vector to store the product
    double[] result = new double[vector.Length];

    // Multiply each element of the vector by the scalar
    for (int i = 0; i < vector.Length; i++)
    {
      result[i] = vector[i] * scalar;
    }

    return result;
  }
}