using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMathTests
{
    public class OperationsTests
    {
        [Test]
        public void MaxTest()
        {
            var list_test = new List<int>()
            {10,4,30,88,90};
            int max = Operations.Max(list_test);
            Assert.AreEqual(max, 90);
        }
        [Test]

        public void EmptyListTest()
        {
            var list_empty = new List<int>();
            int max = Operations.Max(list_empty);
            Assert.AreEqual(max, list_empty.Count);
        }
        [Test]
        public void NegNumTest()
        {
            var list_neg = new List<int>(){-1, -10, -30, -5};
            int neg = Operations.Max(list_neg);
            Assert.AreEqual(neg, -1);
        }
           [Test]
        public void listTest()
        {
            var list_neg = new List<int>(){-1, 50, 100, 0, -7};
            int list = Operations.Max(list_neg);
            Assert.AreEqual(list, 100);
        }
    }
}