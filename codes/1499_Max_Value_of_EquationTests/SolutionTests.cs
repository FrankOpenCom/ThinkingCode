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
            Solution S = new Solution()
            Assert.IsTrue(S.FindMaxValueOfEquation() == 0);
        }
    }
}