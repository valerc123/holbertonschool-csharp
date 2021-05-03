using NUnit.Framework;
using Text;
using System;

namespace TextTests
{
    public class StrTests
    {
        [Test]
        public void PalindromeTest()
        {
            string str = "Racecar";
            bool palindrome = Str.IsPalindrome(str);
            Assert.IsTrue(palindrome);
        }
    }
}