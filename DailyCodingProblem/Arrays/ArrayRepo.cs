using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Arrays
{
    public class ArrayRepo
    {
        public List<int> ProductOfOtherArray(List<int> dataList)
        {

            var sum = dataList.Aggregate(1, (x, y) => x * y);
            var results = new List<int>();

            foreach (var item in dataList)
            {
                var result = sum / item;
                results.Add(result);

            }

            return results;
        }
    }
}
