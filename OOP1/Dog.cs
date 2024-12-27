namespace OOP1;

public class Dog : Animal, IRunnable
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog make sound.");
    }

    public void Run()
    {
        Console.WriteLine("Dog runs.");
    }

    public override void Eat()
    {
        Console.WriteLine("Dog eat bones.");
    }
}
