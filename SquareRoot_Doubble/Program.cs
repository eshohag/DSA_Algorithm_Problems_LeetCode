namespace SquareRoot_Doubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareRoot_Doubble(50));
        }
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n*precision), Space complexity: O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int of indices</returns>
        static float SquareRoot_Doubble(int number)
        {
            int start = 0, end = number;
            int mid;

            // variable to store the answer
            double ans = 0.0;

            // for computing integral part
            // of square root of number
            while (start <= end)
            {
                mid = (start + end) / 2;

                if (mid * mid == number)
                {
                    ans = mid;
                    break;
                }

                // incrementing start if integral
                // part lies on right side of the mid
                if (mid * mid < number)
                {
                    start = mid + 1;
                    ans = mid;
                }

                // decrementing end if integral part
                // lies on the left side of the mid
                else
                {
                    end = mid - 1;
                }
            }

            // For computing the fractional part
            // of square root upto given precision
            double increment = 0.1;
            int precision = 2;
            for (int i = 0; i < precision; i++)
            {
                while (ans * ans <= number)
                {
                    ans += increment;
                }

                // loop terminates when ans * ans > number
                ans = ans - increment;
                increment = increment / 10;
            }
            return (float)ans;
        }
    }
}
