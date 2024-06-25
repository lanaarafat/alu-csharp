using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }
            int count = 1;
            foreach (char letter in s)
            {
                if (Char.IsUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}