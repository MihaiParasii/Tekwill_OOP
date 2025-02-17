namespace OOP1;

internal class Mammal : BaseAnimal
{
    public required string FurColor { get; set; }

    public override string ToString()
    {
        return $"Mammal:\n\tName:\t\t{Name}\n\tSkinColor:\t{FurColor}";
    }
}
