using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace Asssignment1TestCases
{
    public class Class1
    {
        [Test]
        public void ValidEquilateralTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }

        [Test]
        public void ValidIsoscelesTriangle1()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

    }
}
