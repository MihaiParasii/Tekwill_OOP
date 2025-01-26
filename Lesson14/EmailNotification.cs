namespace Lesson14;

public static class EmailNotification
{
    public static void Notify(string message)
    {
        Console.WriteLine($"——>| Sending email notification: {message}");
    }
}
