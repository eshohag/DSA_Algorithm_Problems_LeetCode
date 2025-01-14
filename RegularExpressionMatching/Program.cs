﻿namespace RegularExpressionMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aa", p = "a*";
            Console.WriteLine(IsMatch(s, p));

            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(M∗N), Space complexity: O(M∗N)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns>bool array of indices</returns>
        public static bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int i = 1; i <= n; i++)
            {
                if (p[i - 1] == '*')
                {
                    dp[0, i] = dp[0, i - 2];
                }
            }
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                    }
                }
            }
            return dp[m, n];
        }

    }
}
