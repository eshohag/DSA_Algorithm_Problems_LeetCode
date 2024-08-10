

namespace ReverseWords_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's Write an algorithm to reverse words";
            string result = ReverseWords(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static string ReverseWords(string s)
        {
            var sBuilder = new System.Text.StringBuilder();

            foreach (string word in s.Split(' '))
            {
                sBuilder.Append(Reverse(word)).Append(" ");
            }
            return sBuilder.ToString();
        }

        private static string Reverse(string word)
        {
            char[] ch = word.ToCharArray();
            int start = 0, end = ch.Length - 1;
            char temp;
            while (start < end)
            {
                temp = ch[start];
                ch[start] = ch[end];
                ch[end] = temp;

                end--;
                start++;
            }
            return new string(ch);
        }
    }
}
