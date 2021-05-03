using System;

namespace Text
{
    /// <summary>
    /// Str class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string.
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
            {
                return -1;
            }
            char letter = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (letter != s[i])
                {
                    return i;
                }
                letter = s[i];
            }
            return -1;
        }
    }
}