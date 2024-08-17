namespace Create_Linked_list_from_array
{
    internal class Program
    {  
        // Driver code
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Node root = arrayToList(arr);
            display(root);

            Console.ReadKey();
        }

        // Representation of a node
        public class Node
        {
            public int data;
            public Node next;
        };
        static Node root;

        // Function to insert node
        static Node insert(Node root, int item)
        {
            Node temp = new Node();
            temp.data = item;
            temp.next = root;
            root = temp;
            return root;
        }

        static void display(Node root)
        {
            while (root != null)
            {
                Console.Write(root.data + " ");
                root = root.next;
            }
        }

        //Time Complexity : O(n)
        static Node arrayToList(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i >= 0; i--)
                root = insert(root, arr[i]);
            return root;
        }    
    }
}
