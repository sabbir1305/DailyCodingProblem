using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Stack
{
    public class MaxStack
    {
        public Stack<int> MainStack { get; set; }
        public Stack<int> MStack { get; set; }

        public MaxStack()
        {
            MainStack = new Stack<int>();
            MStack = new Stack<int>();
        }

       public void Push(int val)
        {
            MainStack.Push(val);
            if (MStack.Count > 0)
            {
                MStack.Push(FindMax(val, MStack.Peek()));
            }
            else
            {
                MStack.Push(val);
            }
        }
        public void Pop()
        {
            MainStack.Pop();
            MStack.Pop();
        }

        private int FindMax(int v1,int v2)
        {
            return v1 > v2 ? v1 : v2;
        }
    }
}
