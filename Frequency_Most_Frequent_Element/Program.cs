namespace Frequency_Most_Frequent_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [23, 2, 4, 6, 7];
            int k = 6;
            Console.WriteLine(MaxFrequency(nums, k));
           
            Console.ReadLine();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n*log n), Space complexity: O(log n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int of indices</returns>
        /// The frequency of an element is the number of times it occurs in an array.
        public static int MaxFrequency(int[] nums, int k)
        {
            int ans = 0;
            long sum = 0;

            Array.Sort(nums);
            for (int l = 0, r = 0; r < nums.Length; ++r)
            {
                sum += nums[r];
                while (sum + k < (long)nums[r] * (r - l + 1))
                    sum -= nums[l++];
                ans = Math.Max(ans, r - l + 1);
            }
            return ans;
        }
    }
}
