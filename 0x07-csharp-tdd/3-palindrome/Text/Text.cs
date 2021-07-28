using System;
using System.Collections.Generic;
using System.Linq;

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
            List<char> copyString = new List<char>();
            //s.ToLower();
            if (s.Length == 0){
                return true;
            }else{
                for (int i = 0; i < s.Length; i++)
                    foreach (char letter in s)
                    {
                        if (!Char.IsPunctuation(letter) && !Char.IsWhiteSpace(letter))
                            copyString.Add(Char.ToLower(letter));
                    
                    }
            }
            List<char> revstr = new List<char>(copyString);
            revstr.Reverse();
            return (copyString.SequenceEqual(revstr));
        }
    }
}
