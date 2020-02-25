using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TLuong_QA_A2.Tests
{
    public class TriangleSolverTest
    {
        [Test] //Test 1
        public void ValidTriangleMethod_Input113_NotATriangle()
        {
            //Arrange
            int a = 1;
            int b = 1;
            int c = 3;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Not a triangle", result);
        }

        [Test] //Test 2
        public void ValidEquilateralTriangleMethod_Input333_EquilateralTriangle()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 3;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Equilateral Triangle", result);
        }

        [Test] //Test 3
        public void ValidIsoscelesTriangleMethod_Input434_IsoscelesTriangle()
        {
            //Arrange
            int a = 4;
            int b = 3;
            int c = 4;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Isosceles Triangle", result);
        }

        [Test] //Test 4
        public void SumOf2DimensionsEqualToLastDimensionMethod_Input734_NotATriangle()
        {
            //Arrange
            int a = 7;
            int b = 3;
            int c = 4;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Not a triangle", result);
        }

        [Test] //Test 5
        public void All0DimensionMethod_Input000_NotATriangle()
        {
            //Arrange
            int a = 0;
            int b = 0;
            int c = 0;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Not a triangle", result);
        }

        [Test] //Test 6
        public void AllNegativeDimensionsCloseToIntegerLimitMethod_InputNeg2100000000_Invalid()
        {
            //Arrange
            int a = -2100000000;
            int b = -2100000000;
            int c = -2100000000;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Invalid", result);
        }
    }
}
