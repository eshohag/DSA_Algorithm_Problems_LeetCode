namespace SumTwoIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            var sum = Sum(a, b);
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(1), Space complexity: O(1)
        /// </summary>
        /// <param name="a,b"></param>
        /// <returns>int of indices</returns>
        private static int Sum(int a, int b)
        {
            //return a+b;
            while (b != 0)
            {
                int carry = a & b; // AND operation to find carry
                a = a ^ b;         // XOR operation to add without carry
                b = carry << 1;    // shift carry left by one to add in the next position
            }
            return a;
        }
    }
}
