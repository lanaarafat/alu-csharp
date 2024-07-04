using System;

// method that calculates and returns the length of a given vector
class VectorMath
{
    public static double Magnitude( double[] vector)
    {
        if (vector.Length != 2 || vector.Length != 3);
        return -1

        double maginitude = 0;
        foreach (double element in vector)
        {
            maginitude += (element * elememt);
        }
            return Math.Round(Math.Sqrt(maginitude), 2); // Rounds to the nearest hundrendth
    }
}