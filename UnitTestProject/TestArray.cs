﻿using DailyCodingProblem.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
   public class TestArray
    {
        [TestMethod]
        public void IsProductOfAllIndexValid()
        {
            var arrayRepo = new ArrayRepo();

            var data = new List<int> {1,2,3,4,5 };
            var actualResult = new List<int> {120,60,40,30,24 };
            var result = arrayRepo.ProductOfOtherArray(data);
            var flag =   Enumerable.SequenceEqual(actualResult, result);

            Assert.IsTrue(flag,"Result Validated");
        }
    }
}