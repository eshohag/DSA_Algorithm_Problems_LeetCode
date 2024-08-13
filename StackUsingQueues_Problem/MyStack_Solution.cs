using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingQueues_Problem
{   
     /// <summary>
     /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
     /// </summary>
     /// <param name="x"></param>
     /// <returns>ListNode of indices</returns>
    public class MyStack_Solution
    {
        Queue<int> queue;
        /** Initialize your data structure here. */
        public MyStack_Solution()
        {
            this.queue = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            this.queue.Enqueue(x);
            int n = queue.Count;
            while (n > 1)
            {
                queue.Enqueue(queue.Dequeue());
                n--;
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (queue.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
