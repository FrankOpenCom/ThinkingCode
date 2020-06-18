using Microsoft.VisualStudio.TestTools.UnitTesting;
using _778_Swim_in_Rising_Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _778_Swim_in_Rising_Water.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void SwimInWaterTest()
        {
            Solution s = new Solution();
            int[][] grid = new int[][]
                {
                    new int[] { 0, 2 },
                    new int[] { 1, 3 },
                };
            Assert.IsTrue(s.SwimInWater(grid) == 3);
        }

        [TestMethod()]
        public void SwimInWaterTest001()
        {
            Solution s = new Solution();
            int[][] grid = new int[][]
                {
                    new int[] { 0,1,2,3,4 },
                    new int[] { 24,23,22,21,5 },
                    new int[] { 12,13,14,15,16 },
                    new int[] { 11,17,18,19,20 },
                    new int[] { 10, 9, 8, 7, 6 }
                };
            Assert.IsTrue(s.SwimInWater(grid) == 16);
        }
    }
}

