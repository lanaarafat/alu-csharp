using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This is our class Matrix.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// This is our class Matrix.
        /// </summary>
        public static int Max(List<int> nums)
        {
            int i;

            if (nums == null || nums.Count == 0)
                return(0);

            int max = nums[0];
            int nums_lenght = nums.Count;

            for(i = 0 ; i < nums_lenght ; i++)
                if (max < nums[i])
                    max = nums[i];
            return(max);
        }
    }
}
