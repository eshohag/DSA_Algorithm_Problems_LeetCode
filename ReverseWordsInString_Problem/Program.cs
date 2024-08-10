using System.Linq;

namespace ReverseWordsInString_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var s = "the sky is blue";
            var s = "a good   example";
            Console.WriteLine(ReverseWords(s));
            Console.ReadKey();
        }
        public static string ReverseWords(string s)
        {
            var options = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;
            string[] array = s.Split(' ', options);
            int start = 0, end = array.Length - 1;
            string temp = String.Empty;
            while (start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                end--;
                start++;
            }
            return String.Join(" ", array);
        }
    }
}
