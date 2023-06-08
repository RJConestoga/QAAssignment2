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
        /*Req 1 - Only one (1) test for a valid equilateral triangle*/
        [Test]
        public void ValidEquilateralTriangleTest_CorrectSideLength_ExpectedTrue()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }

        /*Req 2 - Three (3) tests for a valid isosceles triangle*/
        [Test]
        public void ValidIsoscelesTriangleTest1_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void ValidIsoscelesTriangleTest2_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 4;
            int side2 = 7;
            int side3 = 7;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void ValidIsoscelesTriangleTest3_CorrectSideLengths_ExpectedIsosceles()
        {
            int side1 = 5;
            int side2 = 9;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        /*Req 3 - Five (5) tests for a valid scalene triangle*/
        [Test]
        public void ValidScaleneTriangleTest1_CorrectSideLengths_ExpectedScalene()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void ValidScaleneTriangleTest2_CorrectSideLengths_ExpectedScalene()
        {
            int side1 = 7;
            int side2 = 10;
            int side3 = 12;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void ValidScaleneTriangleTest3_CorrectSideLengths_ExpectedScalene()
        {
            int side1 = 12;
            int side2 = 16;
            int side3 = 20;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void ValidScaleneTriangleTest4_CorrectSideLengths_ExpectedScalene()
        {
            int side1 = 5;
            int side2 = 6;
            int side3 = 8;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void ValidScaleneTriangleTest5_CorrectSideLengths_ExpectedScalene()
        {
            int side1 = 9;
            int side2 = 11;
            int side3 = 14;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        /*Req 4 - Three (3) tests for verifying a zero length for one or more sides*/
        [Test]
        public void ZeroLengthTest1_ZeroLengthForSide_ExpectedInvalidTriangle()
        {
            int side1 = 0;
            int side2 = 5;
            int side3 = 6;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void ZeroLengthTest2_ZeroLengthForSide_ExpectedInvalidTriangle()
        {
            int side1 = 50;
            int side2 = 0;
            int side3 = 60;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void ZeroLengthTest3_ZeroLengthForSide_ExpectedInvalidTriangle()
        {
            int side1 = 72;
            int side2 = 73;
            int side3 = 0;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        /*Req 5 - Three (3) tests for verifying an invalid response (other than a zero length)*/
        [Test]
        public void InvalidOtherThanZeroTest1_InvalidInput_NoTriangleFormed()
        {
            int side1 = 10;
            int side2 = 10;
            int side3 = 20;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void InvalidOtherThanZeroTest2_InvalidInput_NoTriangleFormed()
        {
            int side1 = 2;
            int side2 = 2;
            int side3 = 4;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void InvalidOtherThanZeroTest3_InvalidInput_NoTriangleFormed()
        {
            int side1 = 10;
            int side2 = 20;
            int side3 = 40;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

    }
}
