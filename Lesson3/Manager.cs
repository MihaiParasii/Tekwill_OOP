namespace OOP1;

internal class Manager(string name, string department) : Employee(name)
{
    public string Department { get; set; } = department;

    public override string ToString()
    {
        return $"Manager:\n\tName:\t\t{Name}\n\tDepartment:\t{Department}";
    }
}
