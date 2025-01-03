namespace Lesson5;

internal class Accountant(string name, int workedYears) : Employee(name, workedYears)
{
    protected override double CalculateSalary()
    {
        double result = MinimumSalary;

        result += MinimumSalary * 0.2 * WorkedYears;

        return result;
    }

    public override string ToString()
    {
        return $"Accountant: {name} Salary: {CalculateSalary()}";
    }
}
