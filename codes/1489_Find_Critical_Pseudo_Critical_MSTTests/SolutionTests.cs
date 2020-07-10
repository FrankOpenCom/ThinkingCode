using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1489_Find_Critical_Pseudo_Critical_MST;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _1489_Find_Critical_Pseudo_Critical_MST.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindCriticalAndPseudoCriticalEdgesTest()
        {
            Solution s = new Solution();
            int[][] edges = new int[][] 
            {
                new int[] {0,1,1},
                new int[] {1,2,1},
                new int[] {2,3,2},
                new int[] {0,3,2},
                new int[] {0,4,3},
                new int[] {3,4,3},
                new int[] {1,4,6}
            };

            List<List<int>> ret = new List<List<int>>()
            {
                new List<int> {0,1},
                new List<int> {2,3,4,5}
            };

            IList<IList<int>> e = s.FindCriticalAndPseudoCriticalEdges(5, edges);

            bool r1 = ret[0].All(e[0].Contains) && ret[0].Count == e[0].Count;
            bool r2 = ret[1].All(e[1].Contains) && ret[1].Count == e[1].Count;
            Assert.IsTrue(r1 && r2);
        }

        [TestMethod()]
        public void FindCriticalAndPseudoCriticalEdgesTest03()
        {
            Solution s = new Solution();
            int[][] edges = new int[][]
            {
                new int[] {0,1,3}
            };

            List<List<int>> ret = new List<List<int>>()
            {
                new List<int> {0},
                new List<int> {}
            };

            IList<IList<int>> e = s.FindCriticalAndPseudoCriticalEdges(2, edges);

            bool r1 = ret[0].All(e[0].Contains) && ret[0].Count == e[0].Count;
            bool r2 = ret[1].All(e[1].Contains) && ret[1].Count == e[1].Count;
            Assert.IsTrue(r1 && r2);
        }

        [TestMethod()]
        public void FindCriticalAndPseudoCriticalEdgesTest08()
        {
            Solution s = new Solution();
            int[][] edges = new int[][]
            {
                new int[] {0,1,2},
                new int[] {0,2,5},
                new int[] {2,3,5},
                new int[] {1,4,4},
                new int[] {2,5,5},
                new int[] {4,5,2}
            };

            List<List<int>> ret = new List<List<int>>()
            {
                new List<int> {0,2,3,5},
                new List<int> {1,4}
            };

            IList<IList<int>> e = s.FindCriticalAndPseudoCriticalEdges(6, edges);

            bool r1 = ret[0].All(e[0].Contains) && ret[0].Count == e[0].Count;
            bool r2 = ret[1].All(e[1].Contains) && ret[1].Count == e[1].Count;
            Assert.IsTrue(r1 && r2);
        }
    }
}