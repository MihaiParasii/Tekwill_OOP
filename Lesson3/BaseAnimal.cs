namespace OOP1;

public class BaseAnimal
{
    public required string Name { get; set; }

    public override string ToString()
    {
        return $"Animal:\n\tName:\t{Name}";
    }
}
