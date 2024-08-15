using System.Linq;

namespace Duplicates_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 1, 2];
            var result = FindDuplicates(nums);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }
        public static IList<int> FindDuplicates(int[] nums)
        {
            var duplicates = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                    duplicates.Add(Math.Abs(nums[i]));
                else
                    nums[Math.Abs(nums[i]) - 1] *= -1;
            }
            return duplicates;
        }
    }
}
