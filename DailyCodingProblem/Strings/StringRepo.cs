using DailyCodingProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        #region Print Zigzag form
        //Given a string and a number of lines k , make zigzag
        //line=5 => 7,5,3,1
        public int GetSpaces(int row,bool desc,int k)
        {
            var max_spaces = (k - 1) * 2 - 1;
            int spaces = 0;
            if (desc)
            {
                spaces = max_spaces - row * 2;
                return spaces;
            }
            spaces = max_spaces - (k - 1 - row) * 2;
            return spaces;
        }

        public bool IsDescending(int index,int k)
        {
            //check whether the index is more or less than halfway
            return index % (2 * (k - 1)) < k - 1;
        }

        public string ZigZag(string sentence,int k)
        {
            StringBuilder builder = new StringBuilder();
            int n = sentence.Length;
            int i;
          
       
            string spaces = "".PadLeft(n, ' ');
            for (int row = 0; row < k; row++)
            {
               var builder2 = new StringBuilder();
                i = row;
                builder2.Append(spaces);

                while (i<n)
                {
                    builder2[i] = sentence[i];
                    bool desc = IsDescending(i, k);
                    int numberOfSpace = GetSpaces(row, desc, k);
                    i += numberOfSpace + 1;

                }
                builder.Append(builder2.ToString());
                builder.Append('\n');
            }

            return builder.ToString();
        }

        #endregion
    }

}
