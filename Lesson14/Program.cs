using Castle.Core.Logging;

namespace Lesson14;

internal static class Program
{
    private static void Main()
    {
        var eventManager = new EventManager();
        var e1 = new Event(1, "Birthday");
        var e2 = new Event(2, "WWDC 2025");

        eventManager.AddNotification(Console.WriteLine)
            .AddNotification(EmailNotification.Notify)
            .AddNotification(PushNotification.Push);

        try
        {
            eventManager.AddEvent(e1);
            Console.WriteLine();

            eventManager.AddEvent(e2);
            Console.WriteLine();

            e2.Description = "WWDC 2026";
            eventManager.UpdateEvent(e2);

            Console.WriteLine();
            eventManager.RemoveNotification(Console.WriteLine);
            e2.Description = "WWDC 2027";
            eventManager.AddEvent(e2);
        }
        catch (ArgumentException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.ResetColor();
        }
    }
}
