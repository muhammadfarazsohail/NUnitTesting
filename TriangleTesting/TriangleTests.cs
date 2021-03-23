using NUnit.Framework;
using NUnitTestingAsgn;
using System;

namespace TriangleTesting
{
    public class TriangleTests
    {
        //this tests if when we provide a value it gives equilateral triangle result or not
        [Test]
        public void EquilateralTest()
        {
            //Arrange
            var T = new Triangles();
            //Act
            int valR = T.isTriangle(4, 4, 4);
            //Assert
            Assert.AreEqual(1, valR);
        }

        //this tests if when we provide a value it gives isoceles triangle result or not
        [Test]
        public void IsocelesTest()
        {
            //Arrange
            var T = new Triangles();
            //Act
            int valR = T.isTriangle(4, 4, 3);
            //Assert
            Assert.AreEqual(2, valR);
        }

        //this tests if when we provide a value it gives scalene triangle result or not
        [Test]
        public void ScaleneTest()
        {
            //Arrange
            var T = new Triangles();
            //Act
            int valR = T.isTriangle(2, 4, 3);
            //Assert
            Assert.AreEqual(3, valR);
        }

        //this tests if when we provide certain values it gives certain form of triangle type or not
        [TestCase(2, 3, 4, 3)]
        [TestCase(2, 2, 2, 1)]
        [TestCase(2, 2, 1, 2)]
        [TestCase(0, 0, 0, 1)]
        [TestCase(-1, -1, -1, 1)]
        [TestCase(-1, -2, -3, -1)]
        public void isTriangleTest(int a,int b, int c, int d)
        {
            //Arrange
            var T = new Triangles();
            //Act
            int valR = T.isTriangle(a, b, c);
            //Assert
            Assert.AreEqual(d, valR);
        }

        //this tests if when we provide certain values it tells if the values entered are okay or not 
        [TestCase(12, 3, 12, ExpectedResult = true)]
        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(4, 4, 4, ExpectedResult = true)]
        [TestCase(-1, 3, 12, ExpectedResult = false)]
        [TestCase(12, 0, 12, ExpectedResult = false)]
        public Boolean sideCheckerTest(int a, int b, int c)
        {
            //Arrange
            var T = new Triangles();
            //Act
            return T.sideChecker(a,b,c);
        }

    }
}