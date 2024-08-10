
namespace ReverseArray_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr = { 1, 10, 3, 4, 5, 6 };
            Console.Write("Original array is \n");
            printArray(arr);
            reverseArray(arr, start: 0, end: arr.Length - 1);
            Console.Write("Reversed array is \n");
            printArray(arr);

            Console.ReadKey();
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private static void reverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;

                end--;
                start++;
            }
        }

        private static void printArray(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
