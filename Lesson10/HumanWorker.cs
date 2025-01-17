namespace Lesson10;

public class HumanWorker : IWorker, IEater
{
    public void Work()
    {
        Console.WriteLine("Human working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating...");
    }
}
