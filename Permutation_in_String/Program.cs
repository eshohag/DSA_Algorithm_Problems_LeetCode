namespace Permutation_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ab", s2 = "eidbaooo";
            Console.WriteLine(CheckInclusion(s1, s2));

            Console.ReadLine();
        }
        public static bool CheckInclusion(string s1, string s2)
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            bool found = false;

            foreach (char i in s1)
            {
                if (d1.ContainsKey(i))
                {
                    d1[i] = d1[i] + 1;
                }
                else
                {
                    d1[i] = 1;
                }
            }

            Queue<char> q1 = new Queue<char>();
            foreach (char c2 in s2)
            {
                q1.Enqueue(c2);
                if (d2.ContainsKey(c2))
                {
                    d2[c2] = d2[c2] + 1;
                }
                else
                {
                    d2[c2] = 1;
                }

                if (q1.Count > s1.Length)
                {
                    char z = q1.Dequeue();
                    d2[z]--;
                }

                if (q1.Count == s1.Length)
                {
                    found = d1.Keys.All(x => d2.ContainsKey(x) && d1[x] == d2[x]);
                    if (found)
                        return true;
                }
            }

            return found;
        }
    }
}
