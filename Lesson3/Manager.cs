namespace OOP1;

public class Manager(string name, string department) : Employee(name)
{
    public string Department { get; set; } = department;

    public override string ToString()
    {
        return $"Manager:\n\tName:\t\t{Name}\n\tDepartment:\t{Department}";
    }
}
