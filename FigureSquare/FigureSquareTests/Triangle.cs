using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureSquare.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Square_SidesAre0_0Return()
        {
            //arrange
            Triangle triangle = new Triangle(0, 0, 0);

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(0, square);
        }

        [TestMethod]
        public void Square_OneSideIs0_0Return()
        {
            //arrange
            Triangle triangle = new Triangle(1, 1, 0);

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(0, square);
        }

        [TestMethod]
        public void Square_3and4and5_6Return()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            double correctSquare = 6;

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(correctSquare, square);
        }

        [TestMethod]
        public void Square_TwoSidesAreEqualTheOther()
        {
            //arrange
            Triangle triangle = new Triangle(1, 4, 5);

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(0, square);
        }

        [TestMethod]
        public void IsWrongTriangle_OneOrSeveralSidesAreNegative()
        {
            //arrange
            Triangle triangle = new Triangle(-1, 2, 2);

            //act
            double square = triangle.Square;

            //assert
            Assert.AreEqual(Double.NaN, square);
        }

        [TestMethod]
        public void IsRightTriangle_SidesAre0_RightReturn()
        {
            //arrange
            Triangle triangle = new Triangle(0, 0, 0);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void IsRightTriangle_3and4and5_TrueReturn()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void IsRightTriangle_7and6and5_FalseReturn()
        {
            //arrange
            Triangle triangle = new Triangle(7, 6, 5);

            //act
            bool isRight = triangle.IsRightTriangle();

            //assert
            Assert.IsFalse(isRight);
        }
    }
}
