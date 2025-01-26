namespace Lesson14;

public class Event(int id, string description)
{
    public int Id { get; } = id;
    public string Description { get; set; } = description;
}
