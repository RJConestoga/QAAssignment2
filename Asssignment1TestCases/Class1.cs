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
        /*Req 1*/
        [Test]
        public void ValidEquilateralTriangleTest_CorrectSideLength_ExpectedTrue()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }

        /*Req 2*/
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
            int side1 = 4;
            int side2 = 7;
            int side3 = 7;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        /*Req 3*/
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

    }
}
