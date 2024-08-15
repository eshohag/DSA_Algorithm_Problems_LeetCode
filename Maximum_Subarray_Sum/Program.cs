namespace Maximum_Subarray_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums =[-2, 1, -3, 4, -1, 2, 1, -5, 4];
            Console.WriteLine(MaxSubArray(nums));
            Console.ReadLine();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int of indices</returns>
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue, sum = 0;
            foreach (int cur in nums)
            {
                sum += cur;
                maxSum = Math.Max(sum, maxSum);
                sum = sum > 0 ? sum : 0;
            }
            return maxSum;
        }
    }
}
