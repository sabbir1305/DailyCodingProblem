using DailyCodingProblem.Arrays;
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
        [TestMethod]
        public void IsProductOfAllIndexValidWithoutDevide()
        {
            var arrayRepo = new ArrayRepo();

            var data = new List<int> { 1, 2, 3, 4, 5 };
            var actualResult = new List<int> { 120, 60, 40, 30, 24 };

            var result = arrayRepo.GetProductOfArrayWithoutDiv(data);
            var flag = Enumerable.SequenceEqual(actualResult, result);

            Assert.IsTrue(flag, "Result Validated");
        }

        [TestMethod]
        public void IsSmallWindowCorrectBySortedWay()
        {
            var arrayRepo = new ArrayRepo();
            var data = new int[]{ 3, 7, 5, 6, 9 };
            var result = arrayRepo.LocateSmallestWindowBySorted(data);
            var checkLeft = result.left == 1 ? true : false;
            var checkRight = result.right == 3 ? true : false;

            Assert.IsTrue(checkLeft, "Left Failed");
            Assert.IsTrue(checkRight, "Right Failed");

        }

        [TestMethod]
        public void IsWindowCorrect()
        {
            var arrayRepo = new ArrayRepo();
            var data = new int[] { 3, 7, 5, 6, 9 };
            var result = arrayRepo.Window(data);
            var checkLeft = result.left == 1 ? true : false;
            var checkRight = result.right == 3 ? true : false;

            Assert.IsTrue(checkLeft, "Left Failed");
            Assert.IsTrue(checkRight, "Right Failed");

        }

        [TestMethod]
        public void CheckMaxSubArraySum()
        {
            var arrayRepo = new ArrayRepo();
          //  var arr = new int[] { 34, -50, 42, 14, -5, 86 };
            var arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };

            var maxSum = arrayRepo.MaxSubarraySum(arr)==7?true:false;
            var minSubSum = arrayRepo.MinSubArraySum(arr)==-5?true:false;
            var wrapArounMax = arrayRepo.MaximumCircularSubArray(arr)==7?true:false;

            Assert.IsTrue(maxSum, "Finding Max Sub Array Sum Failed");
            Assert.IsTrue(minSubSum, "Finding Min Sub Array Sum Failed");
            Assert.IsTrue(wrapArounMax, "Finding Wrap around Sub Array Sum Failed");
            

        }
    }
}
