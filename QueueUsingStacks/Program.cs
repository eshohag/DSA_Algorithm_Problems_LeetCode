namespace QueueUsingStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Queue  
            System.Collections.Queue myQueue = new System.Collections.Queue();
            myQueue.Enqueue(11);
            myQueue.Enqueue(1);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());

            // Converting the Queue 
            // into object array 
            Object[] arr = myQueue.ToArray();

            // Displaying the elements in array 
            foreach (Object obj in arr)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
