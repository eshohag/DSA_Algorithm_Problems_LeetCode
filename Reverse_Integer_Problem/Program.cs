
namespace Reverse_Integer_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = -1234;

            int reverse = GetReverseInteger(input);
            Console.WriteLine(reverse);
           
            Console.ReadKey();
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(log(x)), Space complexity: O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int of indices</returns>
        private static int GetReverseInteger(int x)
        {
            long ans = 0;
            while (x != 0)
            {
                ans = ans * 10 + x % 10;
                x /= 10;
            }
            return (ans < int.MinValue || ans > int.MaxValue) ? 0 : (int)ans;
        }
    }
}
