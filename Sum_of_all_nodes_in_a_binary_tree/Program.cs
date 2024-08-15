namespace Sum_of_all_nodes_in_a_binary_tree
{
    internal class Program
    {
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int of indices</returns>
        public static int Sum_of_all_nodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return (root.key + Sum_of_all_nodes(root.left) + Sum_of_all_nodes(root.right));
        }

        // Driver Code 
        public static void Main(string[] args)
        {
            Node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            root.right.left = newNode(6);
            root.right.right = newNode(7);
            root.right.left.right = newNode(8);

            int sum = Sum_of_all_nodes(root);
            Console.WriteLine("Sum of all the elements is: " + sum);
        }
        public class Node
        {
            public int key;
            public Node left, right;
        }

        /* utility that allocates a new  
           Node with the given key */
        public static Node newNode(int key)
        {
            Node node = new Node();
            node.key = key;
            node.left = node.right = null;
            return (node);
        }

    }
}
