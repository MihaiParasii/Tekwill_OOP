namespace OOP1;

public class Parrot : Bird
{
    public required string Vocabulary { get; set; }

    public override string ToString()
    {
        return $"Parrot:\n\tName:\t\t{Name}\n\tFlyType:\t{FlyType}\n\tVocabulary:\t{Vocabulary}";
    }
}
