namespace Lesson5;

public abstract class Employee(string name, int workedYears)
{
    public string Name { get; private init; } = name;
    protected int WorkedYears { get; private init; } = workedYears;
    protected const int MinimumSalary = 10_000;

    protected abstract double CalculateSalary();

    public new abstract string ToString();
}
