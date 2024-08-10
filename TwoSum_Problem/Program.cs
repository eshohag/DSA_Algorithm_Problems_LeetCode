namespace TwoSum_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 0, 3, 0 };
            //int[] array = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];

            int target = 4;

            int[] normalApproche_Result = TwoSum_Solution.NormalSolution(array, target);
            Console.WriteLine(string.Join(" ", normalApproche_Result));

            int[] optimizedSolution = TwoSum_Solution.OptimizedSolution(array, target);
            Console.WriteLine(string.Join(" ", optimizedSolution));

            Console.ReadKey();
        }
    }
}
