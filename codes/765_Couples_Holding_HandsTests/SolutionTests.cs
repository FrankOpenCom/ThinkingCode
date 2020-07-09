using Microsoft.VisualStudio.TestTools.UnitTesting;
using _765_Couples_Holding_Hands;
using System;
using System.Collections.Generic;
using System.Text;

namespace _765_Couples_Holding_Hands.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinSwapsCouplesTest000()
        {
            Solution s = new Solution();
            int[] row = new int[]
            {
                3, 2, 0, 1
            };
            Assert.IsTrue(s.MinSwapsCouples(row) == 0);
        }

        [TestMethod()]
        public void MinSwapsCouplesTest001()
        {
            Solution s = new Solution();
            int[] row = new int[]
            {
                0, 2, 1, 3
            };
            Assert.IsTrue(s.MinSwapsCouples(row) == 1);
        }
    }
}