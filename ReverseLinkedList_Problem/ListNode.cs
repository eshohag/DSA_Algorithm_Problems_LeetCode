using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList_Problem
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;

        // Constructor to initialize a new node with data
        public ListNode(int newData = 0, ListNode next = null)
        {
            Val = newData;
            Next = next;
        }
    }
}
