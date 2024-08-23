namespace Minimum_Sum_with_K_operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [ 10, 20, 7 ];
            int k = 4;
            Array.Sort(arr);
            while (k > 0)
            {
                var Ceiling = Math.Ceiling((decimal)arr[arr.Length - 1] / (decimal)2);
                arr[arr.Length - 1] = (int)Ceiling;
                Array.Sort(arr);
                k--;
            }

            Console.WriteLine("Array is "+String.Join(" ", arr)+ ", Total Sum is " + arr.Sum());

            Console.ReadKey();
        }
    }
}
