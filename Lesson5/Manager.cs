namespace Lesson5;

internal class Manager(string name, int workedYears) : Employee(name, workedYears)
{
    protected override double CalculateSalary()
    {
        double result = MinimumSalary;

        result += MinimumSalary * 0.3 * WorkedYears;

        return result;
    }

    public override string ToString()
    {
        return $"Manager: {name} Salary: {CalculateSalary()}";
    }
}
