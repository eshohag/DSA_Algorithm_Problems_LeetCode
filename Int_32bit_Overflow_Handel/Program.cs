namespace Int_32bit_Overflow_Handel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                unchecked
                {
                    int max = int.MaxValue;
                    Console.WriteLine($"int.MaxValue {max:N0}");
                    int sum = max++;
                    Console.WriteLine($"Total Sum {sum:N0}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
