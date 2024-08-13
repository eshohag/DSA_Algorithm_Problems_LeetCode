using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStacks
{
    /// <summary>
    /// Using a Dictionary: Time Complexity: O(1), Space complexity: O(n)
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns>ListNode of indices</returns>
    public class MyQueue_Solution
    {
        Stack<int> inStack;
        Stack<int> outStack;
        public MyQueue_Solution()
        {
            inStack = new Stack<int>();
            outStack = new Stack<int>();
        }

        public void Push(int x)
        {
            inStack.Push(x);
        }

        public int Pop()
        {
            dummyStackIn();
            return outStack.Pop();
        }

        public int Peek()
        {
            dummyStackIn();
            return outStack.Peek();
        }

        public bool Empty()
        {
            return inStack.Count == 0 && outStack.Count == 0;
        }

        private void dummyStackIn()
        {
            if (outStack.Count != 0) return;
            while (inStack.Count != 0)
            {
                outStack.Push(inStack.Pop());
            }
        }
    }
}
