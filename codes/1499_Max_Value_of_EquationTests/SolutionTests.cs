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

        [TestMethod()]
        public void FindMaxValueOfEquationTest001()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {-15,-1},
                new int[] {-14,-5},
                new int[] {-11,1},
                new int[] {-9,7},
                new int[] {-8,18},
                new int[] {-7,-5},
                new int[] {-3,3},
                new int[] {4,14},
                new int[] {12,-4},
                new int[] {13,15},
                new int[] {14,-19},
                new int[] {19,-1}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 8) == 26);
        }

        [TestMethod()]
        public void FindMaxValueOfEquationTest002()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {-17,-6},
                new int[] {-4,0},
                new int[] {-2,-16},
                new int[] {-1,2},
                new int[] {0,11},
                new int[] {6,18}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 13) == 35);
        }

        [TestMethod()]
        public void FindMaxValueOfEquationTest003()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {-17,5},
                new int[] {-10,-8},
                new int[] {-5,-13},
                new int[] {-2,7},
                new int[] {8,-14}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 4) == -3);
        }

        [TestMethod()]
        public void FindMaxValueOfEquationTest004()
        {
            Solution S = new Solution();
            int[][] points = new int[][]
            {
                new int[] {-12,-5},
                new int[] {-9,-6},
                new int[] {-8,-2},
                new int[] {-7,-20},
                new int[] {-6,-15},
                new int[] {-4,-20},
                new int[] {5,3},
                new int[] {14,-6},
                new int[] {19,19}
            };
            Assert.IsTrue(S.FindMaxValueOfEquation(points, 9) == 18);
        }
    }
}