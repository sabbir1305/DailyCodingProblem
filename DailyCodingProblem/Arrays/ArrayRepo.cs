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

        public List<int> GetProductOfArrayWithoutDiv(List<int> dataList)
        {
            var result = new List<int>();

            var prefix_products = new List<int>();
  
   
            int last = 1;
            foreach (var item in dataList)
            {
                last = item * last;
                prefix_products.Add(last);
              
              
            }

            var sufix_products = new List<int>();

             last = 1;
            foreach (var item in dataList.Reverse<int>())
            {
                last = item * last;
                sufix_products.Add( last);
           

            }
            sufix_products.Reverse();

            for (int i = 0; i < dataList.Count; i++)
            {
                if (i == 0)
                {
                    result.Add(sufix_products[i + 1]);
                }
                else if (i == dataList.Count - 1)
                {
                    result.Add(prefix_products[i - 1]);
                }
                else
                {
                    result.Add(prefix_products[i - 1] * sufix_products[i + 1]);
                }
            }

            



            return result;
        }
   
    
        public (int left,int right) LocateSmallestWindowBySorted(int[] dataList)
        {
            var sortedDataList = dataList.OrderBy(x=>x).ToList();
            int left=0, right=0;
            for (int i = 0; i < sortedDataList.Count; i++)
            {
                if(dataList[i] != sortedDataList[i] && left == 0)
                {
                    left = i;
                }
                else if(dataList[i] != sortedDataList[i])
                {
                    right = i;
                }
            }
            return (left, right);
        }
    
        public (int left , int right) Window(int[] dataList)
        {
            int left = 0, right = 0;
            int maxSeen = int.MinValue, minSeen = int.MaxValue;
            for(int i = 0; i < dataList.Length; i++)
            {
                maxSeen = Max(maxSeen, dataList[i]);
                if (dataList[i] < maxSeen)
                    right = i;
            }
            for (int i = dataList.Length - 1; i >= 0; i--)
            {
                minSeen = Min(minSeen, dataList[i]);
                if (dataList[i] > minSeen)
                    left = i;
            }

            return (left, right);
        }
        private int Max(int v1,int v2)
        {
            return v1 > v2 ? v1 : v2;
        }
        private int Min(int v1, int v2)
        {
            return v1 < v2 ? v1 : v2;
        }
  
    
        public int MaxSubarraySum(int[] data)
        {
            int maxEndingHere= 0,maxSoFar = 0;

            foreach (var i in data)
            {
                maxEndingHere = Max(i, maxEndingHere + i);
                maxSoFar = Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }

        public int MinSubArraySum(int[] data)
        {
            int minEndingHere = 0, minSoFar = 0;
            foreach (var item in data)
            {
                minEndingHere = Min(item, minEndingHere + item);
                minSoFar = Min(minSoFar, minEndingHere);
            }
            return minSoFar;
        }

        public int MaximumCircularSubArray(int[] data)
        {
            var MaxSubArraySumWrapAround = data.Sum() - MinSubArraySum(data);
            return Max(MaxSubarraySum(data), MaxSubArraySumWrapAround);
        }
    }
}
