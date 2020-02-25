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
        [Test]
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

        [Test]
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

        [Test]
        public void ValidIsoscelesTriangleMethod_Input334_IsoscelesTriangle()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 4;
            string result;
            //Act
            result = TriangleSolver.Analyze(a, b, c);
            //Assert
            Assert.AreEqual("Isosceles Triangle", result);
        }

        //[Test]
        //public void ValidIsoscelesTriangleMethod_Input334_IsoscelesTriangle()
        //{
        //    //Arrange
        //    int a = 3;
        //    int b = 3;
        //    int c = 4;
        //    string result;
        //    //Act
        //    result = TriangleSolver.Analyze(a, b, c);
        //    //Assert
        //    Assert.AreEqual("Isosceles Triangle", result);
        //}
    }
}
