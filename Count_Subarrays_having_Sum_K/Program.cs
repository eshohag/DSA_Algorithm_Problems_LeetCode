namespace Count_Subarrays_having_Sum_K
{
    internal class Program
    {
        public static int findSubarraySum(int[] arr, int n, int sum)
        {
            Dictionary<int, int> prevSum = new Dictionary<int, int>();

            int res = 0;
            int currsum = 0;
            for (int i = 0; i < n; i++)
            {
                // Add current element to sum so far.
                currsum += arr[i];

                // If currsum is equal to desired sum,
                // then a new subarray is found. So
                // increase count of subarrays.
                if (currsum == sum)
                    res++;

                // currsum exceeds given sum by currsum
                // - sum. Find number of subarrays having
                // this sum and exclude those subarrays
                // from currsum by increasing count by
                // same amount.
                if (prevSum.ContainsKey(currsum - sum))
                    res += prevSum[currsum - sum];

                // Add currsum value to count of
                // different values of sum.
                if (!prevSum.ContainsKey(currsum))
                    prevSum.Add(currsum, 1);
                else
                {
                    int count = prevSum[currsum];
                    prevSum[currsum] = count + 1;
                }
            }
            return res;
        }

        // Driver Code
        public static void Main()
        {
            int[] arr = { 10, 2, -2, -20, 10 };
            int sum = -10;
            int n = arr.Length;
            Console.Write(findSubarraySum(arr, n, sum));
        }
    }
}
