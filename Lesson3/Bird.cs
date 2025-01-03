namespace OOP1;

internal class Bird : BaseAnimal
{
    public required string FlyType { get; set; }
    
    public override string ToString()
    {
        return $"Bird:\n\tName:\t\t{Name}\n\tFlyType:\t{FlyType}";
    }
}
