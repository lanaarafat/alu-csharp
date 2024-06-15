using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This is our class Matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// This is our public static int[,] Divide.
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int i;
            int j;

            if (matrix is null)
                return null;
            if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

            int[,] res = matrix;
            for (i = 0; i < matrix.GetLength(0) ; i++)
            {
                for (j = 0; j < matrix.GetLength(1) ; j++)
                {
                    res[i, j] /= num;
                }
            }
            return res;
        }
    }
}
