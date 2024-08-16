namespace Egg_Drop_With_2_Eggs_and_N_Floors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = TwoEggDrop(10);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int TwoEggDrop(int n)
        {
            int moves = 0;
            int floorsToCheck = 0;

            while (floorsToCheck < n)
            {
                moves++;
                floorsToCheck += moves;
            }
            return moves;
        }
    }
}
