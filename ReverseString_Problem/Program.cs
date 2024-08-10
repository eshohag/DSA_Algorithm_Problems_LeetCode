
namespace ReverseString_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "shohag";
            var reverse = reverseString(arr: a.ToCharArray());
            Console.WriteLine(String.Join("", reverse));

            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>char[] array of indices</returns>
        private static char[] reverseString(char[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }
            int start = 0, end = arr.Length - 1;
            char temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                end--;
                start++;
            }
            return arr;
        }
    }
}
