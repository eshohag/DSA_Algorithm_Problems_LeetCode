namespace Continuous_Subarray_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [23, 2, 4, 6, 7];
            int k = 6;
            Console.WriteLine(CheckSubarraySum(nums,k));
            Console.ReadLine();
        }
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> remainderIndexMap = new Dictionary<int, int>();
            remainderIndexMap[0] = -1;

            int cumulativeSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                cumulativeSum += nums[i];
                int remainder = cumulativeSum % k;
                if (remainderIndexMap.ContainsKey(remainder))
                {
                    if (i - remainderIndexMap[remainder] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    remainderIndexMap[remainder] = i;
                }
            }
            return false;
        }
    }
}
