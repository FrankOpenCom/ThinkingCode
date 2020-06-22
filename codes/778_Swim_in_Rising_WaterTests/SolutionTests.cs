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

        [TestMethod()]
        public void SwimInWaterTest002()
        {
            Solution s = new Solution();
            int[][] grid = new int[][]
                {
                    new int[] { 3,2 },
                    new int[] { 0,1 },
                };
            Assert.IsTrue(s.SwimInWater(grid) == 3);
        }

        [TestMethod()]
        public void SwimInWaterTest003()
        {
            Solution s = new Solution();
            int[][] grid = new int[][]
                {
                    new int[] { 26,99,80,1,89,86,54,90,47,87 },
                    new int[] { 9,59,61,49,14,55,77,3,83,79 },
                    new int[] { 42,22,15,5,95,38,74,12,92,71 },
                    new int[] { 58,40,64,62,24,85,30,6,96,52 },
                    new int[] { 10,70,57,19,44,27,98,16,25,65 },
                    new int[] { 13,0,76,32,29,45,28,69,53,41 },
                    new int[] { 18,8,21,67,46,36,56,50,51,72 },
                    new int[] { 39,78,48,63,68,91,34,4,11,31 },
                    new int[] { 97,23,60,17,66,37,43,33,84,35 },
                    new int[] { 75,88,82,20,7,73,2,94,93,81 }
                };
            Assert.IsTrue(s.SwimInWater(grid) == 81);
        }

        [TestMethod()]
        public void SwimInWaterTest004()
        {
            Solution s = new Solution();
            int[][] grid = new int[][]
                {
                    new int[] { 31,28,33, 0, 8,57,86,99,23,98 },
                    new int[] { 25,90,20,73,34,65,29, 9,42,46 },
                    new int[] { 17,84,10, 4,40, 5,41,21,71,79 },
                    new int[] { 13,70,69,81,63,93,77, 1,94,53 },
                    new int[] { 38,87,61,50,92, 2,15,95,82,68 },
                    new int[] { 44,72,88,47,27,91,37,48,83,16 },
                    new int[] {  3,30,96,66, 7,58,76,54,19,64 },
                    new int[] { 85,45,60,11,51,26, 6,22,74,32 },
                    new int[] { 43,12,62,59,89,52,36,97,49,78 },
                    new int[] { 75,24,14,67,56,35,55,39,80,18 }
                };
            Assert.IsTrue(s.SwimInWater(grid) == 78);
        }
    }
}

