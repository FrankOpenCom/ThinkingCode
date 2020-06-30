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
    }
}