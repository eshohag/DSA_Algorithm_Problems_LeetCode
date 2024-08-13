namespace Sort_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 10, 4, 5 };

            int[] sort = GetSortArray(arr);
            Console.WriteLine(String.Join(" ", sort));

            Console.ReadKey();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int[] of indices</returns>
        private static int[] GetSortArray(int[] nums)
        {
            int minValue = nums.Min();
            int maxValue = nums.Max();
            int range = maxValue - minValue + 1;
            int[] count = new int[range];
            int[] output = new int[nums.Length];

            // Count the occurrences of each number
            foreach (int num in nums)
            {
                count[num - minValue]++;
            }

            // Update the count array to hold the actual positions
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Build the output array
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                output[count[nums[i] - minValue] - 1] = nums[i];
                count[nums[i] - minValue]--;
            }

            return output;
        }
    }
}
