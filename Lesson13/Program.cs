namespace Lesson13;

internal static class Program
{
    private static async Task Main()
    {
        await Ex3();
    }

    private static async Task Ex1()
    {
        var list = await AsyncClass.GenerateRandomNumberAsync();
        Console.WriteLine("Generated numbers: \n");
        list.ForEach(x => Console.Write($"{x} "));
    }

    private static async Task Ex2()
    {
        var numbers = await AsyncClass.GenerateRandomNumberAsync();
        var oddNumbers = await AsyncClass.GetEvenNumbersAsync(numbers);
        Console.WriteLine("\nOdd numbers: \n");
        oddNumbers.ForEach(x => Console.Write($"{x} "));
    }

    private static async Task Ex3()
    {
        var numbers = await AsyncClass.GenerateRandomNumberAsync();

        try
        {
            var oddNumbers = await AsyncClass.GetEvenNumbersAsync(numbers);
            Console.WriteLine("\nOdd numbers: \n");
            oddNumbers.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            oddNumbers = await AsyncClass.GetEvenNumbersAsync([]);
            Console.WriteLine("\nOdd numbers: \n");
            oddNumbers.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }
        catch (ArgumentException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.ResetColor();
        }
    }
}
