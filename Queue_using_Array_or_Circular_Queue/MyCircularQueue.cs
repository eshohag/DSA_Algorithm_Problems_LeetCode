using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_Array_or_Circular_Queue
{
    public class MyCircularQueue
    {
        private int[] buf;
        private int start;
        private int end;

        public MyCircularQueue(int k)
        {
            start = -1;
            end = -1;
            buf = new int[k];
        }

        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            if (start == -1)
            {
                start = 0;
            }
            ++end;
            if (end == buf.Length) end = 0;
            buf[end] = value;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            if (start == end)
            {
                start = -1;
                end = -1;
            }
            else
            {
                ++start;
                if (start == buf.Length) start = 0;
            }
            return true;
        }

        public int Front()
        {
            if (IsEmpty()) return -1;
            return buf[start];
        }

        public int Rear()
        {
            if (IsEmpty()) return -1;
            return buf[end];
        }

        public bool IsEmpty()
        {
            return start == -1;
        }

        public bool IsFull()
        {
            return start == ((end + 1) % buf.Length);
        }
    }
}
