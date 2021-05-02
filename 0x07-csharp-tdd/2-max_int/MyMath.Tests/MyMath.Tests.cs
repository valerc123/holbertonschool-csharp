using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void MaxTest()
        {
            var list_test = new List<int>()
            {10,4,30,88};
            int max = Operations.Max(list_test);
            Assert.AreEqual(max, 88);
        }
    }
}