using Lesson11;

namespace TestLesson11;

public static class StringUtilsTest
{
    [Theory]
    [InlineData("ababa", true)]
    [InlineData("Was it a car or a cat I saw?", false)]
    [InlineData("Hello, world!", false)]
    [InlineData("12321", true)]
    [InlineData("racecar", true)]
    public static void IsPalindromeTests(string input, bool expectedResult)
    {
        bool result = StringUtils.IsPalindrome(input);
        Assert.Equal(expectedResult, result);
    }
}
