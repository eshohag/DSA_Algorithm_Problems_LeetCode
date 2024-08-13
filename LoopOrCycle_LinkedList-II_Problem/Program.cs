namespace LoopOrCycle_LinkedList_II_Problem
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

            var detect = DetectCycle(head);

            Console.ReadKey();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns>ListNode of indices</returns>
        public static ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    slow = head;
                    while (slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return slow;
                }
            }
            return null;
        }
        private static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(" " + node.val);
                node = node.next;
            }
        }
    }
}
