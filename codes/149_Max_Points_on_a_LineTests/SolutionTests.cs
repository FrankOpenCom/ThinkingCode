using Microsoft.VisualStudio.TestTools.UnitTesting;
using _149_Max_Points_on_a_Line;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _149_Max_Points_on_a_Line.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MaxPointsTest()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {1,1},
                new int[] {2,2},
                new int[] {3,3}
            };
            Assert.IsTrue(S.MaxPoints(points) == 3);
        }

        [TestMethod()]
        public void MaxPointsTest001()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {1,1},
                new int[] {3,2},
                new int[] {5,3},
                new int[] {4,1},
                new int[] {2,3},
                new int[] {1,4}
            };
            Assert.IsTrue(S.MaxPoints(points) == 4);
        }

        [TestMethod()]
        public void MaxPointsTest002()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {0,0},
                new int[] {1,1},
                new int[] {0,0}
            };
            Assert.IsTrue(S.MaxPoints(points) == 3);
        }

        [TestMethod()]
        public void MaxPointsTest003()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {3,10},
                new int[] {0,2},
                new int[] {0,2},
                new int[] {3,10}
            };
            Assert.IsTrue(S.MaxPoints(points) == 4);
        }

        [TestMethod()]
        public void MaxPointsTest004()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {0,0},
                new int[] {94911150, 94911151},
                new int[] {94911151, 94911152}
            };
            Assert.IsTrue(S.MaxPoints(points) == 2);
        }


        [TestMethod()]
        public void MaxPointsTest005()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {0,0},
                new int[] {1, 65536},
                new int[] { 65536, 0}
            };
            Assert.IsTrue(S.MaxPoints(points) == 2);
        }

        [TestMethod()]
        public void MaxPointsTest006()
        {
            Solution S = new Solution();
            int[][] points = new int[][]{
                new int[] {15,12},
                new int[] {9,10},
                new int[] {-16,3},
                new int[] {-15,15},
                new int[] {11,-10},
                new int[] {-5,20},
                new int[] {-3,-15},
                new int[] {-11,-8},
                new int[] {-8,-3},
                new int[] {3,6},
                new int[] {15,-14},
                new int[] {-16,-18},
                new int[] {-6,-8},
                new int[] {14,9},
                new int[] {-1,-7},
                new int[] {-1,-2},
                new int[] {3,11},
                new int[] {6,20},
                new int[] {10,-7},
                new int[] {0,14},
                new int[] {19,-18},
                new int[] {-10,-15},
                new int[] {-17,-1},
                new int[] {8,7},
                new int[] {20,-18},
                new int[] {-4,-9},
                new int[] {-9,16},
                new int[] {10,14},
                new int[] {-14,-15},
                new int[] {-2,-10},
                new int[] {-18,9},
                new int[] {7,-5},
                new int[] {-12,11},
                new int[] {-17,-6},
                new int[] {5,-17},
                new int[] {-2,-20},
                new int[] {15,-2},
                new int[] {-5,-16},
                new int[] {1,-20},
                new int[] {19,-12},
                new int[] {-14,-1},
                new int[] {18,10},
                new int[] {1,-20},
                new int[] {-15,19},
                new int[] {-18,13},
                new int[] {13,-3},
                new int[] {-16,-17},
                new int[] {1,0},
                new int[] {20,-18},
                new int[] {7,19},
                new int[] {1,-6},
                new int[] {-7,-11},
                new int[] {7,1},
                new int[] {-15,12},
                new int[] {-1,7},
                new int[] {-3,-13},
                new int[] {-11,2},
                new int[] {-17,-5},
                new int[] {-12,-14},
                new int[] {15,-3},
                new int[] {15,-11},
                new int[] {7,3},
                new int[] {19,7},
                new int[] {-15,19},
                new int[] {10,-14},
                new int[] {-14,5},
                new int[] {0,-1},
                new int[] {-12,-4},
                new int[] {4,18},
                new int[] {7,-3},
                new int[] {-5,-3},
                new int[] {1,-11},
                new int[] {1,-1},
                new int[] {2,16},
                new int[] {6,-6},
                new int[] {-17,9},
                new int[] {14,3},
                new int[] {-13,8},
                new int[] {-9,14},
                new int[] {-5,-1},
                new int[] {-18,-17},
                new int[] {9,-10},
                new int[] {19,19},
                new int[] {16,7},
                new int[] {3,7},
                new int[] {-18,-12},
                new int[] {-11,12},
                new int[] {-15,20},
                new int[] {-3,4},
                new int[] {-18,1},
                new int[] {13,17},
                new int[] {-16,-15},
                new int[] {-9,-9},
                new int[] {15,8},
                new int[] {19,-9},
                new int[] {9,-17}
            };
            Assert.IsTrue(S.MaxPoints(points) == 6);
        }
    }
}