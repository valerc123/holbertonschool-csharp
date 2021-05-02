using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void AddTest()
        {
            int a = 35;
            int b = 45;
            int c = Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
    }
}
