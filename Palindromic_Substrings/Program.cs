namespace Palindromic_Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine(CountSubstrings(s));
            Console.ReadKey();
        }
        public static int CountSubstrings(string s)
        {
            int ans = 0;
            int n = s.Length;
            for (int k = 0; k < n * 2 - 1; ++k)
            {
                int i = k / 2, j = (k + 1) / 2;
                while (i >= 0 && j < n && s[i] == s[j])
                {
                    ++ans;
                    --i;
                    ++j;
                }
            }
            return ans;
        }
    }
}
