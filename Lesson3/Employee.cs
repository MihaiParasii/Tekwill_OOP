namespace OOP1;

internal class Employee(string name)
{
    public string Name { get; set; } = name;

    public override string ToString()
    {
        return $"Employee:\n\tName:\t{Name}";
    }
}
