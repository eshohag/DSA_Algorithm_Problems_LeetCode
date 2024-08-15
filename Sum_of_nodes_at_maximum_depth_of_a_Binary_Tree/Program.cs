namespace Sum_of_nodes_at_maximum_depth_of_a_Binary_Tree
{
    internal class Program
    {
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(b), Here b is the width of the tree and the extra space is used to store the elements of the current level in the queue.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int of indices</returns>
        public static int deepestLeavesSum(TreeNode root)
        {
            // if the root is null then return 0
            if (root == null)
            {
                return 0;
            }
            // Initialize an empty queue.
            Queue<TreeNode> qu = new Queue<TreeNode>();
            // push the root of the tree into the queue
            qu.Enqueue(root);

            // initialize sum of current level to 0
            int sumOfCurrLevel = 0;

            // loop until the queue is not empty
            while (qu.Count != 0)
            {
                int size = qu.Count;
                sumOfCurrLevel = 0;
                while (size-- > 0)
                {
                    TreeNode head = qu.Dequeue();
                    sumOfCurrLevel += head.val;

                    // if the left child of the head is not null
                    if (head.left != null)
                    {

                        //push the child into the queue
                        qu.Enqueue(head.left);
                    }

                    // if the right child is not null
                    if (head.right != null)
                    {

                        // push the child into the queue
                        qu.Enqueue(head.right);
                    }
                }
            }
            return sumOfCurrLevel;
        }
        public static void Main(String[] args)
        {

            TreeNode root;
            root = createNode(1);
            root.left = createNode(2);
            root.right = createNode(3);
            root.left.left = createNode(4);
            root.left.right = createNode(5);
            root.right.left = createNode(6);
            root.right.right = createNode(7);

            Console.WriteLine(deepestLeavesSum(root));
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
        };

        // Function to return a new node
        static TreeNode createNode(int d)
        {
            TreeNode node;
            node = new TreeNode();
            node.val = d;
            node.left = null;
            node.right = null;
            return node;
        }

    }
}
