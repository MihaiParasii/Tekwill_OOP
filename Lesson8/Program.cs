namespace Lesson8;

internal static class Program
{
    private static void Main()
    {
        Ex1();
    }

    private static void Ex1()
    {
        var filtering = BookRepository.Books.Where(b => b.Author == "Andrew Troelsen");
        var ordering = BookRepository.Books.OrderByDescending(b => b.Year);
        var projecting = BookRepository.Books.Where(b => b.CopiesAvailable >= 1).Select(b => b.Title);
        int aggregation = BookRepository.Books.Aggregate((acc, book) =>
        {
            acc.CopiesAvailable += book.CopiesAvailable;
            return acc;
        }).CopiesAvailable;
        var distinction = BookRepository.Books.Select(b => b.Author).Distinct();
        var pagination = BookRepository.Books.Skip((2 - 1) * 2).Take(2).OrderBy(b => b.Title);

        Console.WriteLine("Filtering:");
        PrintEnumerable(filtering);

        Console.WriteLine("\nOrdering:");
        PrintEnumerable(ordering);

        Console.WriteLine("\nProjecting:");
        PrintEnumerable(projecting);

        Console.WriteLine("\nAggregation:");
        Console.WriteLine($"Total copies available: {aggregation}");

        Console.WriteLine("\nDistinction:");
        PrintEnumerable(distinction);

        Console.WriteLine("\nPagination:");
        PrintEnumerable(pagination);
    }

    private static void PrintEnumerable<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}
