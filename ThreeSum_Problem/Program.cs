namespace ThreeSum_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };

            ThreeSum(nums);

            Console.ReadLine();
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);  //Step-1
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < length - 2 && nums[i] <= 0; ++i)  //Step-2
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int j = i + 1, k = length - 1;
                while (j < k)
                {
                    int x = nums[i] + nums[j] + nums[k];
                    if (x < 0)
                    {
                        ++j;
                    }
                    else if (x > 0)
                    {
                        --k;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[j--], nums[k--] });
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            ++j;
                        }
                        while (j < k && nums[k] == nums[k + 1])
                        {
                            --k;
                        }
                    }
                }
            }
            return result;
        }
    }
}
