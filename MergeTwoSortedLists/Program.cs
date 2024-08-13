namespace MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(2);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(5);

            var merged = MergeTwoLists(list1, list2);
            PrintList(merged);

            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(M∗N), Space complexity: O(1)
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns>ListNode of indices</returns>
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //Basic Filtering 
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            //Logic
            while (list1 != null && list2 != null)
            {
                int value = 0;
                if (list1.val <= list2.val)
                {
                    value = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    value = list2.val;
                    list2 = list2.next;
                }
                ListNode tmp = new ListNode(value);
                current.next = tmp;
                current = current.next;
            }

            if (list1 == null) current.next = list2;
            else if (list2 == null) current.next = list1;

            return dummy.next;
        }

        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(" " + node.val);
                node = node.next;
            }
        }
    }
}
