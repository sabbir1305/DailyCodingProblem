using DailyCodingProblem.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
  public  class TestStack
    {
        [TestMethod]
        public void IsBalancedBrackets()
        {
            var _repo = new StackRepo();

            var data = "([])[]({})";
            var actualResult = true;

            var result = _repo.IsBalancedBracket(data);
           

            Assert.IsTrue(actualResult==result, "Result Validated");
        }
    }
}
