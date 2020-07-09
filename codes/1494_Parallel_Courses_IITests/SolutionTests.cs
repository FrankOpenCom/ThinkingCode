using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1494_Parallel_Courses_II;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1494_Parallel_Courses_II.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinNumberOfSemestersTest0000()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {2,1},
                new int[] {3,1},
                new int[] {1,4}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(4, dependencies, 2) == 3);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0001()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {2,1},
                new int[] {3,1},
                new int[] {4,1},
                new int[] {1,5}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(5, dependencies, 2) == 4);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0002()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
            };
            Assert.IsTrue(S.MinNumberOfSemesters(11, dependencies, 2) == 6);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0053()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,2},
                new int[] {1,3},
                new int[] {7,5},
                new int[] {7,6},
                new int[] {4,8},
                new int[] {8,9},
                new int[] {9,10},
                new int[] {10,11},
                new int[] {11,12}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(12, dependencies, 2) == 6);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0056()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3},
                new int[] {4,5},
                new int[] {5,6},
                new int[] {7,8},
                new int[] {8,9},
                new int[] {10,11},
                new int[] {11,12}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(12, dependencies, 3) == 4);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0057()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,3},
                new int[] {1,4},
                new int[] {2,3},
                new int[] {2,4},
                new int[] {5,6},
                new int[] {6,7},
                new int[] {7,8}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(8, dependencies, 2) == 4);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0039()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,5},
                new int[] {1,3},
                new int[] {1,2},
                new int[] {4,2},
                new int[] {4,5},
                new int[] {2,5},
                new int[] {1,4},
                new int[] {4,3},
                new int[] {3,5},
                new int[] {3,2}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(5, dependencies, 3) == 5);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0054()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,5},
                new int[] {2,5},
                new int[] {3,5},
                new int[] {4,6},
                new int[] {4,7},
                new int[] {4,8},
                new int[] {4,9}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(9, dependencies, 3) == 3);
        }

        [TestMethod()]
        public void MinNumberOfSemestersTest0062()
        {
            Solution S = new Solution();
            int[][] dependencies = new int[][]
            {
                new int[] {1,4},
                new int[] {1,5},
                new int[] {3,5},
                new int[] {3,6},
                new int[] {2,6},
                new int[] {2,7},
                new int[] {8,4},
                new int[] {8,5},
                new int[] {9,6},
                new int[] {9,7}
            };
            Assert.IsTrue(S.MinNumberOfSemesters(9, dependencies, 3) == 3);
        }
    }
}