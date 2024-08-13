namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 4, 5 };
            Console.WriteLine(RemoveDuplicates(arr));
            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int[] of indices</returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[i + 1] = nums[j];
                    i++;
                }
            }
            return i + 1;
        }
    }
}
