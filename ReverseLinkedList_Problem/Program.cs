namespace ReverseLinkedList_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a hard-coded linked list:
            // 1 -> 2 -> 3 -> 4 -> 5
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);

            // Print the original linked list
            Console.Write("Given Linked list:");
            PrintList(head);

            // Function call to return the reversed list
            head = ReverseList(head);

            // Print the reversed linked list
            Console.Write("Reversed Linked List:");
            PrintList(head);

            Console.ReadKey();
        }
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(" " + node.Val);
                node = node.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="head"></param>
        /// <returns>ListNode</returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode newHead = null, current = head;
            while (current != null)
            {
                ListNode newNode = new ListNode();
                newNode.Val = current.Val;
                newNode.Next = newHead;

                newHead = newNode;

                current = current.Next;  //Loop continue if next element has a value
            }
            return newHead;
        }
    }
}
