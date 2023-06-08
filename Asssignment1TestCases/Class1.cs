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
        public void ValidEquilateralTriangleTest_CorrectSideLength_ExpectedTrue()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }

        
        [Test]
        public void ValidIsoscelesTriangleTest1_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("Test Case 1: This triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void ValidIsoscelesTriangleTest2_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 4;
            int side2 = 7;
            int side3 = 7;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("Test Case 2: This triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void ValidIsoscelesTriangleTest3_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 4;
            int side2 = 7;
            int side3 = 7;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("Test Case 3: This triangle is valid and is an ISOSCELES", result);
        }

    }
}
