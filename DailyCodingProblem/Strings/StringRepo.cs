using DailyCodingProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Strings
{
    public class StringRepo
    {
       public List<IntDataPair> GeneratePalindromePairs(string[] words)
        {
            List<IntDataPair> results = new List<IntDataPair>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i == j)
                        continue;
                    var str = words[i] + words[j];
                    if (IsPallindrome(str,0,str.Length-1)){
                        results.Add(new IntDataPair(i,j ));
                    }
                }
            }
            return results;
        }
        private bool IsPallindrome(String str,int start,int end)
        {

            // If there is only one character 
            if (start == end)
                return true;

            // If first and last character 
            // do not match 
            if ((str[start]) != (str[end]))
                return false;

            // If there are more than two 
            // characters, check if middle 
            // substring is also 
            // palindrome or not. 
            if (start < end + 1)
                return IsPallindrome(str, start + 1,end - 1);
            return true;
        }
    }

}
