using DailyCodingProblem.Models;
using DailyCodingProblem.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{

    [TestClass]
   public class TestString
    {
        public void TestAnagramIndices()
        {
            string s = "abxaba";
            string w = "ab";
            var ExpectedResult = new List<int> { 0,3,4};

        }
        [TestMethod]
        public void TestPalidromePairs()
        {
            var Repo = new StringRepo();
            string[] words = { "code", "edoc", "da", "d"};
            var expectedResult = new List<IntDataPair>();
            expectedResult.Add(new IntDataPair(0, 1));
            expectedResult.Add(new IntDataPair(1, 0));
            expectedResult.Add(new IntDataPair(2, 3));

            var returendResulty = Repo.GeneratePalindromePairs(words);

             Assert.IsTrue(expectedResult.SequenceEqual(returendResulty),"Result Validated");
          

        }
    }
}
