namespace Lesson14;

public class EventManager
{
    private readonly List<EventNotification> _notifications = [];
    private readonly List<Event> _events = [];

    public EventManager AddNotification(EventNotification notification)
    {
        _notifications.Add(notification);
        return this;
    }

    private void Notify(string message)
    {
        foreach (var notification in _notifications)
        {
            notification(message);
        }
    }

    public void RemoveNotification(EventNotification notification)
    {
        _notifications.Remove(notification);
    }

    public void AddEvent(Event @event)
    {
        var e = _events.FirstOrDefault(e => e.Id == @event.Id);

        if (e is not null)
        {
            throw new ArgumentException("Event with this Id already exists");
        }

        _events.Add(@event);
        Notify($"Add new Event: {@event.Description}");
    }

    public void UpdateEvent(Event @event)
    {
        var e = _events.FirstOrDefault(e => e.Id == @event.Id);

        if (e is null)
        {
            throw new ArgumentException("Event with this Id not found");
        }

        e.Description = @event.Description;

        Notify($"Updated event: {e.Description}");
    }
}
