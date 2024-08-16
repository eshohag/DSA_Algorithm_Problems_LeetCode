namespace Capacity_To_Ship_Packages_Within_D_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] weights = { 1, 2, 3, 4, 5, 6,7 };
            int d = 5;
            Console.WriteLine(ShipWithinDays(weights, d));
            Console.ReadKey();
        }
        public static int ShipWithinDays(int[] weights, int days)
        {
            int left = weights.Max();
            int right = weights.Sum();
            int n = weights.Length;
            // Performing binary search to find the least weight
            // capacity.
            while (left < right)
            {
                int mid = (left + right) / 2;
                int need = 1, curr = 0;

                // Iterating over the weights and checking if
                // the
                // current truck can carry up to the mid weight.
                for (int i = 0; i < n; i++)
                {
                    if (curr + weights[i] > mid)
                    {

                        // If the current truck cannot carry the
                        //  current weight, we need to use a new
                        // truck and reset the current weight.
                        curr = 0;
                        need++;
                    }
                    curr += weights[i];
                }

                // If the number of trucks needed exceeds the
                // given limit, we need to increase the weight
                // capacity and update left.
                if (need > days)
                    left = mid + 1;

                // If the number of trucks needed is within the
                // given limit, we can try to reduce the weight
                // capacity and update right.
                else
                    right = mid;
            }

            // Returning the least weight capacity.
            return left;
        }
    }
}
