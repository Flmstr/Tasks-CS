using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareFigures;

namespace FiguresTest
{
    [TestClass]
    public class FiguresTest
    {
        [TestMethod]
        public void SquareCircle()
        {
            double Expect = 50.26548245743669;
            Circle CircleTest = new SquareFigures.Circle(4);
            Assert.AreEqual(Expect, CircleTest.Square());
        }

        [TestMethod]
        public void SquareTriangle()
        {
            double Expect = 2.9047375096555625;
            Triangle TriangleTest = new SquareFigures.Triangle(4, 3, 2);
            Assert.AreEqual(Expect, TriangleTest.Square());
        }

        [TestMethod]
        public void RectangularTriangle()
        {
            bool ExpectTrue = true;
            Triangle TriangleTestTrue = new SquareFigures.Triangle(3, 4, 5);
            Assert.AreEqual(ExpectTrue, TriangleTestTrue.Rectangular());

            bool ExpectFalse = false;
            Triangle TriangleTestFalse = new SquareFigures.Triangle(3, 4, 6);
            Assert.AreEqual(ExpectFalse, TriangleTestFalse.Rectangular());
        }

        [TestMethod]
        public void ExceptionCircle()
        {
            Assert.ThrowsException<System.Exception>(() => new SquareFigures.Circle(0));
        }

        [TestMethod]
        public void ExceptionTriangle()
        {
            Assert.ThrowsException<System.Exception>(() => new SquareFigures.Triangle(3, 4, 0));
        }


    }

}
