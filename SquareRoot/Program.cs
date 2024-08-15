namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(9));
            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int of indices</returns>
        public static int MySqrt(int x)
        {
            int left = 0;        // Initialize the left boundary of the search space
            int right = x;       // Initialize the right boundary of the search space

            while (left < right)
            {
                int mid = (left + right + 1) >>> 1; // Compute the middle point, using unsigned right shift for safe division by 2

                if (mid <= x / mid)
                { // If the square of mid is less than or equal to x
                    left = mid;        // Move the left boundary to mid
                }
                else
                {
                    right = mid - 1;   // Otherwise, discard mid and the right search space
                }
            }
            return left;
        }
    }
}
