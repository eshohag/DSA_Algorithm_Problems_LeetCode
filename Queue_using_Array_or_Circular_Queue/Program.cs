namespace Queue_using_Array_or_Circular_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue obj = new MyCircularQueue(10);
            bool param_1 = obj.EnQueue(1);
            bool param_2 = obj.DeQueue();
            int param_3 = obj.Front();
            int param_4 = obj.Rear();
            bool param_5 = obj.IsEmpty();
            bool param_6 = obj.IsFull();
            Console.ReadKey();
        }

    }
}
