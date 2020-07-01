using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1499_Max_Value_of_Equation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1499_Max_Value_of_Equation.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindMaxValueOfEquationTest()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {1,3},
                new int[] {2,0},
                new int[] {5,10},
                new int[] {6,-10}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 1) == 4);
        }


        [TestMethod()]
        public void FindMaxValueOfEquationTest000()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {0,0},
                new int[] {3,0},
                new int[] {9,2}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 3) == 3);
        }
    }
}