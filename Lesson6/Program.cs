using System.Numerics;

namespace Lesson6;

internal static class Program
{
    private static void Main()
    {
        Ex1();
    }

    private static void Ex1()
    {
        var intOperations = new MathOperations<int>();
        Console.WriteLine("Int operations:");
        Console.WriteLine(intOperations.Add(1, 2));
        Console.WriteLine(intOperations.Substract(1, 2));
        Console.WriteLine(intOperations.Multiply(1, 2));
        Console.WriteLine(intOperations.Divide(1, 2));


        var decimalOperations = new MathOperations<decimal>();
        Console.WriteLine("\nDecimal operations:");
        Console.WriteLine($"{decimalOperations.Add(3.1m, 2.1m):F2}");
        Console.WriteLine($"{decimalOperations.Substract(3.1m, 2.1m):F2}");
        Console.WriteLine($"{decimalOperations.Multiply(3.1m, 2.1m):F2}");
        Console.WriteLine($"{decimalOperations.Divide(3.1m, 2.1m):F2}");
    }
}
