namespace Lesson7;

public class PriorityQueueItem<T>(T item, int priority)
{
    public T Item { get; set; } = item;
    public int Priority { get; set; } = priority;
}
