using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquare.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_0_0Returned()
        {
            //arrange
            Circle circle = new Circle(0);

            //act
            double square = circle.Square;

            //assert
            Assert.AreEqual(0, square);
        }

        [TestMethod]
        public void Square_4_50Point24Returned()
        {
            //arrange
            Circle circle = new Circle(4);
            double correctSquare = 50.27;

            //act
            double square = Math.Round(circle.Square, 2);

            //assert
            Assert.AreEqual(correctSquare, square);
        }

        [TestMethod]
        public void Square_Negative4_50Point24Returned()
        {
            //arrange
            Circle circle = new Circle(-4);
            double correctSquare = 50.27;

            //act
            double square = Math.Round(circle.Square, 2);

            //assert
            Assert.AreEqual(correctSquare, square);
        }
    }
}
