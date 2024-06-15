using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// This is our class Matrix.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// This is our class Matrix.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            string new_string = String.Join("", s.ToLower().Split(' ', ',', '.', ':', ';', '\''));
            int strLen = new_string.Length - 1;

            foreach (char letter in new_string)
            {
                if ( letter != new_string[strLen])
                    return false;
                strLen--;
            }
            return true;
        }
    }
}
