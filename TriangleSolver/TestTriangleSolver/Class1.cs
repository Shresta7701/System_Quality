using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework.Legacy;
using NUnit.Framework;


namespace TestTriangleSolver
{
    public class Class1
    {
        [TestFixture]
        public class TriangleTests
        {
            // 1. Valid Equilateral Triangle TestCase
            [Test]
            public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
            {
                string result = Triangle.AnalyzeTriangle(5, 5, 5);
                ClassicAssert.AreEqual("Equilateral triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_TwoSidesEqual1()
            {
                string result = Triangle.AnalyzeTriangle(6, 6, 4);
                ClassicAssert.AreEqual("Isosceles triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_TwoSidesEqual2()
            {
                string result = Triangle.AnalyzeTriangle(7, 5, 7);
                ClassicAssert.AreEqual("Isosceles triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_TwoSidesEqual3()
            {
                string result = Triangle.AnalyzeTriangle(8, 10, 10);
                ClassicAssert.AreEqual("Isosceles triangle", result);
            }

            //Scalene triangle TestCases

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent1()
            {
                string result = Triangle.AnalyzeTriangle(3, 4, 5);
                ClassicAssert.AreEqual("Scalene triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent2()
            {
                string result = Triangle.AnalyzeTriangle(5, 7, 10);
                ClassicAssert.AreEqual("Scalene triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent3()
            {
                string result = Triangle.AnalyzeTriangle(6, 9, 12);
                ClassicAssert.AreEqual("Scalene triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent4()
            {
                string result = Triangle.AnalyzeTriangle(10, 11, 12);
                ClassicAssert.AreEqual("Scalene triangle", result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent5()
            {
                string result = Triangle.AnalyzeTriangle(15, 17, 19);
                ClassicAssert.AreEqual("Scalene triangle", result);
            }


        }
    }
}
