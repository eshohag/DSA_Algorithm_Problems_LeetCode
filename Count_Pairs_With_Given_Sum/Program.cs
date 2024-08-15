namespace Count_Pairs_With_Given_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Code
            int[] arr = { 1, 5, 7, -1 };
            int sum = 6;

            // Function call
            Console.WriteLine($"Count of pairs is {getPairsCount(arr, sum)}");

            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(length*log(length)), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int of indices</returns>
        public static int getPairsCount(int[] arr, int sum)
        {
            Array.Sort(arr);
            int c = 0;
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int x = sum - arr[i];
                int y = lowerBound(arr, i + 1, length, x);
                int z = upperBound(arr, i + 1, length, x);
                c = c + z - y;
            }
            return c;
        }

        public static int lowerBound(int[] arr, int start, int end, int key)
        {
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return start;
        }

        //UpperBound implementation
        public static int upperBound(int[] arr, int start,int end, int key)
        {
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] <= key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return start;
        }    
    }
}
