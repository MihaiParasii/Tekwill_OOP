using System.Text;

namespace Lesson8;

public class Book
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required int Year { get; set; }
    public required int CopiesAvailable { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("Book Details: —————————————————");
        sb.AppendLine($"ID: {Id}");
        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Author: {Author}");
        sb.AppendLine($"Year: {Year}");
        sb.AppendLine($"Copies Available: {CopiesAvailable}");
        sb.AppendLine("End Details: ——————————————————");
        sb.AppendLine();
        
        return sb.ToString();
    }
}
