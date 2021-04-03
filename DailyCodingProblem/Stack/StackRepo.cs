using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Stack
{
    public class StackRepo
    {
        public bool IsBalancedBracket(string bracket)
        {
            Stack<char> Brackets = new Stack<char>();
            foreach (var ch in bracket.ToCharArray())
            {
                if(ch=='(' || ch=='[' || ch== '{')
                {
                    Brackets.Push(ch);
                }
                else
                {
                    if (Brackets.Count == 0)
                    {
                        return false;
                    }
                    char lastCh = Brackets.Peek();
                    if ((ch == ')' && lastCh != '(') 
                        || (ch == '}' && lastCh != '{')
                         || (ch == ']' && lastCh != '[')

                        )
                    {
                        return false;
                    }
                    Brackets.Pop();
                }
            }
            return Brackets.Count==0;
        }
    }
}
