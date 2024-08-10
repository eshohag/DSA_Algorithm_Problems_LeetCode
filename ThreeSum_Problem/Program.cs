namespace ThreeSum_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            int sum = 0;
            var triplets = ThreeSum(nums, sum);
            foreach (var single in triplets)
            {
                Console.WriteLine(String.Join(" ", single));
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Using a Dictionary: Time complexity: O(n^2), Space complexity: O(1), As no extra space is required
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>IList<IList<int>></returns>
        public static IList<IList<int>> ThreeSum(int[] nums, int sum)
        {
            Array.Sort(nums);  //Step-1
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < length - 2; ++i)
            {
                if (i > 0 && nums[i] == nums[i - 1]) //Duplicate Checking
                {
                    continue;
                }

                int left = i + 1, right = length - 1;
                while (left < right)
                {
                    int x = nums[i] + nums[left] + nums[right];
                    if (x == sum)
                    {
                        result.Add(new List<int> { nums[i], nums[left--], nums[right--] });
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            ++left;
                        }
                        while (left < right && nums[right] == nums[right + 1])
                        {
                            --right;
                        }
                    }
                    else if (x > sum)
                    {
                        --right;
                    }
                    else  //x < sum
                    {
                        ++left;
                    }
                }
            }
            return result;
        }
    }
}
