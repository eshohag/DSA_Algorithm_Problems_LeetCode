namespace Maximal_Square_find_the_largest_square_sub_matrix_which_contains_only_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(m*n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int of indices</returns>
        public static int MaximalSquare(char[][] matrix)
        {
            int m = matrix.Length, n = matrix[0].Length;
            var dp = new int[n + 1];
            int mx = 0, prev = 0;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    int temp = dp[j + 1];
                    if (matrix[i][j] == '1')
                    {
                        dp[j + 1] = Math.Min(Math.Min(dp[j], dp[j + 1]), prev) + 1;
                        mx = Math.Max(mx, dp[j + 1]);
                    }
                    else
                    {
                        dp[j + 1] = 0;
                    }
                    prev = temp;
                }
            }
            return mx * mx;
        }
    }
}
