namespace Lesson11;

public static class StringUtils
{
    public static bool IsPalindrome(string input)
    {
        string cleanedInput = input.ToLower().Replace(" ", "");
        string reversedInput = Reverse(cleanedInput);
        return cleanedInput == reversedInput;
    }

    private static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
