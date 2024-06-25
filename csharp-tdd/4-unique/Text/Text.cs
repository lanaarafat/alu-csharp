using System;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            string dot = ".";
            char hold;
            string used = "";
            for (int i = 0; i < s.Length; i++)
            {
                hold = s[i];
                s = dot + s.Remove(i, 1);
                if (!s.Contains(Char.ToString(hold)) && !used.Contains(Char.ToString(hold)))
                {
                    return i;
                }
                used += hold;
            }
            return -1;
        }
    }
}