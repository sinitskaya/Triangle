using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle_Library;

namespace Triangle_UnitTests
{
    [TestClass]
    public class Triangle_UnitTests
    {
        [TestMethod]
        public void TriangleNotExist1()
        {
            Assert.AreEqual("Triangle does not exist", Triangle.typeTriangle(1, 1, 5));
        }

        [TestMethod]
        public void TriangleNotExist2()
        {
            Assert.AreEqual("Triangle does not exist", Triangle.typeTriangle(1, 1, 2));
        }

        [TestMethod]
        public void TriangleExist()
        {
            Assert.AreNotEqual("Triangle does not exist", Triangle.typeTriangle(1, 3, 3));
        }

        [TestMethod]
        public void TriangleIsRectangular()
        {
            Assert.AreEqual("Triangle is rectangular", Triangle.typeTriangle(3, 4, 5));
        }

        [TestMethod]
        public void TriangleIsAcuteAngled()
        {
            Assert.AreEqual("Triangle is acute-angled", Triangle.typeTriangle(3, 3, 4));
        }

        public void TriangleIsObtuse()
        {
            Assert.AreEqual("Triangle is obtuse", Triangle.typeTriangle(3, 2, 5));
        }
    }
}
