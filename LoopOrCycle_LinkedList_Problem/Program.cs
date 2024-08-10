using System.Xml.Linq;

namespace LoopOrCycle_LinkedList_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a hard-coded linked list:
            // 10 -> 20 -> 30 -> 40 -> 50 -> 60
            ListNode head = new ListNode(10);
            head.next = new ListNode(20);
            head.next.next = new ListNode(30);
            head.next.next.next = new ListNode(40);
            head.next.next.next.next = new ListNode(50);
            head.next.next.next.next.next = new ListNode(60);

            // Creating a loop resulting in the linked list:
            // 10 -> 20 -> 30 -> 40 -> 10 -> 20 -> 30 ...
            head.next.next.next.next = head;

            if (HasCycle_Optimum_Solution(head))
                Console.WriteLine("Loop Found");
            else
                Console.WriteLine("No Loop");
            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns>bool array of indices</returns>
        public static bool HasCycle_Optimum_Solution(ListNode head)
        {
            //Linked List Cycle - Floyd's Tortoise https://www.youtube.com/watch?v=gBTe7lFR3vc
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns>bool array of indices</returns>
        public static bool HasCycle_Normal_Solution(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (head != null)
            {
                if (visited.Contains(head))
                {
                    return true;
                }
                visited.Add(head);
                head = head.next;
            }
            return false;
        }
    }
}
