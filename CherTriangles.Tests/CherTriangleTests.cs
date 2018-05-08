using System;
using CherTriangles.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CherTriangles.Tests
{
    [TestClass]
    public class CherTriangleTests
    {
        [TestMethod]
        public void TestGetTriangleCoordinatesByRowAndColumnOdd()
        {
            var controller = new TrianglesController();

            var result = controller.GetCoordinates("D", 5);

            Assert.AreEqual(result.V1x, 20);
            Assert.AreEqual(result.V1y, 40);
            Assert.AreEqual(result.V2x, 20);
            Assert.AreEqual(result.V2y, 30);
            Assert.AreEqual(result.V3x, 30);
            Assert.AreEqual(result.V3y, 40);
        }

        [TestMethod]
        public void TestGetTriangleCoordinatesByRowAndColumnEven()
        {
            var controller = new TrianglesController();

            var result = controller.GetCoordinates("D", 6);

            Assert.AreEqual(result.V1x, 30);
            Assert.AreEqual(result.V1y, 30);
            Assert.AreEqual(result.V2x, 20);
            Assert.AreEqual(result.V2y, 30);
            Assert.AreEqual(result.V3x, 30);
            Assert.AreEqual(result.V3y, 40);
        }

        [TestMethod]
        public void TestGetTriangleByCoordsEven()
        {
            var controller = new TrianglesController();
            var result = controller.GetTriangleByCoords(30,30,20,30,30,40);

            Assert.AreEqual(result, "D6");
        }

        [TestMethod]
        public void TestGetTriangleByCoordsOdd()
        {
            var controller = new TrianglesController();
            var result = controller.GetTriangleByCoords(20, 40, 20, 30, 30, 40);
            Assert.AreEqual(result, "D5");
        }

        [TestMethod]
        public void TestGetTriangleByCoords()
        {
            var controller = new TrianglesController();
            var result = controller.GetTriangleByCoords(60, 50, 50, 50, 60, 60);
            Assert.AreEqual(result, "F12");
        }
    }
}
