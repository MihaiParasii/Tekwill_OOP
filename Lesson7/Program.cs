namespace Lesson7;

internal static class Program
{
    private static void Main()
    {
        Ex1();
    }

    private static void Ex1()
    {
        var priorityQueue = new PriorityQueue<int>();

        Console.WriteLine("Enqueue element 5 with priority 3");
        priorityQueue.Enqueue(5, 3);
        Console.WriteLine("Enqueue element 3 with priority 1");
        priorityQueue.Enqueue(3, 1);
        Console.WriteLine("Enqueue element 8 with priority 2");
        priorityQueue.Enqueue(8, 2);
        Console.WriteLine("Enqueue element 2 with priority 4");
        priorityQueue.Enqueue(2, 4);

        Console.WriteLine("\n\nPriority queue:\n" + priorityQueue);
        
        Console.WriteLine("Peek: " + priorityQueue.Peek());

        while (!priorityQueue.IsEmpty())
        {
            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
        }

        try
        {
            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        

        Console.WriteLine("Is priority queue empty? " + priorityQueue.IsEmpty());

        priorityQueue.Enqueue(10, 1);
        priorityQueue.Enqueue(7, 3);

        Console.WriteLine("Peek: " + priorityQueue.Peek());

        while (!priorityQueue.IsEmpty())
        {
            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
        }

        Console.WriteLine("Is priority queue empty? " + priorityQueue.IsEmpty());
        Console.ReadLine();
    }
}
