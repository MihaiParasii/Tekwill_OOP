using Lesson11;

namespace TestLesson11;

public static class StringValidatorTest
{
    [Fact]
    public static void IsValidEmail_ShouldReturnFalse_WhenInputIsEmpty()
    {
        bool result = StringValidator.IsValidEmail("");
        Assert.False(result);
    }

    [Fact]
    public static void IsValidEmail_ShouldReturnFalse_WhenAreMissingSpecialChars()
    {
        bool result = StringValidator.IsValidEmail("example!example,com");
        Assert.False(result);
    }

    [Fact]
    public static void IsValidEmail_ShouldReturnTrue_WhenEmailIsValid()
    {   
        bool result = StringValidator.IsValidEmail("example@example.com");
        Assert.True(result);
    }

    [Theory]
    [InlineData("1234567890", true)]
    [InlineData("0123456789", true)]
    [InlineData("+1234567890", false)]
    [InlineData("123-456-7890", false)]
    [InlineData("01234", false)]
    public static void IsPhoneNumber_Test(string phoneNumber, bool expectedResult)
    {
        bool result = StringValidator.IsPhoneNumber(phoneNumber);
        Assert.Equal(expectedResult, result);
    }

}
