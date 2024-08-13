namespace QueueUsingStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue_Solution obj = new MyQueue_Solution();
            obj.Push(1);
            obj.Push(40);
            obj.Push(10);
            int param_2 = obj.Pop();
            int param_3 = obj.Peek();
            bool param_4 = obj.Empty();

            Console.ReadKey();
        }

    }
}
