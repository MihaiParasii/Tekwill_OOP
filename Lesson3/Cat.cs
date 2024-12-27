namespace OOP1;

public class Cat : Animal, IRunnable
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meow.");
    }

    public void Run()
    {
        Console.WriteLine("Cat runs.");
    }
    
    public override void Eat()
    {
        Console.WriteLine("Cat eats fish.");
    }
}
