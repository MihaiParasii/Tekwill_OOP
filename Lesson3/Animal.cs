namespace OOP1;

internal abstract class Animal
{
    public abstract void MakeSound();

    public virtual void Eat()
    {
        Console.WriteLine("Animal eats.");
    }
}
