using System;

namespace Text
{
    /// <summary>
    /// Class that computes strings
    /// </summary>
    public class Str
    {
        /// <summary>
        /// return true if string is a palindrome word
        /// otherwise return false
        /// </summary>
        public static bool IsPalindrome(string s){
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
