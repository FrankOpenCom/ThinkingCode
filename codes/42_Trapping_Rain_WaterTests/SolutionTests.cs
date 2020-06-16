using Microsoft.VisualStudio.TestTools.UnitTesting;
using _42_Trapping_Rain_Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _42_Trapping_Rain_Water.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            Solution S = new Solution();
            int [] input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Assert.IsTrue(S.Trap(input) == 6);
        }

        [TestMethod()]
        public void TrapTest000()
        {
            Solution S = new Solution();
            int[] input = new int[] { 4,1,3,2,4,2,2 };
            Assert.IsTrue(S.Trap(input) == 6);
        }

        [TestMethod()]
        public void TrapTest001()
        {
            Solution S = new Solution();
            int[] input = new int[] { 5,4,1,2 };
            Assert.IsTrue(S.Trap(input) == 1);
        }
    }
}