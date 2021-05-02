using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquare.Tests
{
    [TestClass]
    public class SomeFigureTests
    {
        [TestMethod]
        public void Square_4_50Point24Returned()
        {
            //arrange
            SomeFigure circle = new SomeFigure(4);
            double correctSquare = 50.27;

            //act
            double square = Math.Round(circle.Square, 2);

            //assert
            Assert.AreEqual(correctSquare, square);
        }

        [TestMethod]
        public void Square_3and4and5_6Return()
        {
            //arrange
            SomeFigure triangle = new SomeFigure(3, 4, 5);
            double correctSquare = 6;

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(correctSquare, square);
        }
    }
}