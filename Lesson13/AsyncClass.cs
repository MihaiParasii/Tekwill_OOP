namespace Lesson13;

public static class AsyncClass
{
    public static async Task<List<int>> GenerateRandomNumberAsync()
    {
        var list = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            list.Add(i);
            await Task.Delay(10);
        }

        return list;
    }

    public static async Task<List<int>> GetEvenNumbersAsync(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("List must have at least one element");
        }

        var oddNumbers = new List<int>();

        await Task.Run(() => { oddNumbers.AddRange(numbers.Where(number => number % 2 == 0)); });

        return oddNumbers;
    }
}
