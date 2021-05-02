using NUnit.Framework;
using System;
using MyMath;

namespace MyMathTests
{
    public class MatrixTests
    {
        [Test]
        public void DivideTest()
        {
            int num = 2;
            int[,] matrix = new int[2, 2]
            {
                {1, 2}, {3, 4}
            };
            int[,] div_res = Matrix.Divide(matrix, num);
            Assert.AreEqual(matrix, div_res);
        }
    }
}