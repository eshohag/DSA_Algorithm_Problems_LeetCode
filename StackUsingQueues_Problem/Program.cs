namespace StackUsingQueues_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack_Solution obj = new MyStack_Solution();
            obj.Push(1);
            int param_2 = obj.Pop();
            int param_3 = obj.Top();
            bool param_4 = obj.Empty();

            Console.ReadKey();
        }
    }
}
