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
            string str = "A man, a plan, a canal: Panama";
            bool palindrome = Str.IsPalindrome(str);
            Assert.IsTrue(palindrome);
        }
        [Test]

        public void emptyTest()
        {
            string str = "";
            bool palindrome = Str.IsPalindrome(str);
            Assert.IsTrue(palindrome);
        }
         [Test]

        public void middleTest()
        {
            string str = "rever";
            bool palindrome = Str.IsPalindrome(str);
            Assert.IsTrue(palindrome);
        }
        [Test]

        public void uniqueTest()
        {
            string str = "ababa";
            bool palindrome = Str.IsPalindrome(str);
            Assert.IsTrue(palindrome);
        }
    }
}