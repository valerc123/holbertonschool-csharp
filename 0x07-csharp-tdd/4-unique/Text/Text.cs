using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> Represents a class Str</summary>
    public class Str
    {
        /// <summary> returns first unique character in string</summary>
        public static int UniqueChar(string s)
        {
            string letter1 = "";
            string letter2 = "";

            if (s == "" || s == null)
                return -1;

            int rep = 0;
            for (int i = 0; i < s.Length; i++)
            {
                letter1 = s.Substring(i, 1);
                int indexMin = 0;
                for (int j = 0; j < s.Length; j++)
                {
                letter2 = s.Substring(j, 1);
                    if ((letter1 == letter2) && (i != j))
                        continue;

                    else if ((letter1 != letter2) && (i != j))
                    {
                        indexMin++;
                        if (indexMin == s.Length - 1 && rep < indexMin)
                        {
                            rep = indexMin;
                            return(i);
                        }
                    }
                }
            }
            return -1; 
        }
    }
}