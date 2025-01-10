using System.Text;

namespace Lesson7;

public class PriorityQueue<T>
{
    private readonly List<PriorityQueueItem<T>> _items = [];

    public void Enqueue(T item, int priority)
    {
        _items.Add(new PriorityQueueItem<T>(item, priority));
        _items.Sort((x, y) => y.Priority.CompareTo(x.Priority));
    }

    public T Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Priority queue is empty");
        }

        var item = _items[0];
        _items.RemoveAt(0);
        return item.Item;
    }

    public T Peek()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Priority queue is empty");
        }

        return _items[0].Item;
    }


    public bool IsEmpty() => _items.Count == 0;

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        foreach (var item in _items)
        {
            sb.AppendLine($"{item.Item} - Priority: {item.Priority}");
        }
        
        return sb.ToString();
    }
}
