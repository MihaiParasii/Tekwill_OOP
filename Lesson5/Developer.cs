namespace Lesson5;

public class Developer : Employee
{
    private readonly List<ProgrammingLanguage> _programmingLanguages;

    public Developer(string name, int workedYears, List<ProgrammingLanguage> programmingLanguages = null!) : base(name, workedYears)
    {
        _programmingLanguages = programmingLanguages;

        foreach (var language in programmingLanguages.Where(language => !_programmingLanguages.Contains(language)))
        {
            _programmingLanguages.Add(language);
        }
    }

    protected override double CalculateSalary()
    {
        double result = MinimumSalary;

        foreach (var language in _programmingLanguages)
        {
            if (language == ProgrammingLanguage.Csharp)
            {
                result += MinimumSalary * 4;
                continue;
            }

            result += MinimumSalary * 0.5;
        }

        return result;
    }

    public override string ToString()
    {
        return $"Developer: {Name}, {WorkedYears} years, " +
               $"{_programmingLanguages.Count} programming languages. Salary: {CalculateSalary()}";
    }
}
