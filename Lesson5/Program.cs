namespace Lesson5;

internal static class Program
{
    private static void Main()
    {
        Ex1();
    }

    private static void Ex1()
    {
        var employees = new Employee[3];

        employees[0] = new Manager("John Doe", 5);
        employees[1] = new Developer("Jane Smith", 3, [ProgrammingLanguage.Csharp, ProgrammingLanguage.C, ProgrammingLanguage.Cpp, ProgrammingLanguage.Rust, ProgrammingLanguage.C]);
        employees[2] = new Accountant("Alice Johnson", 7);

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }
}
