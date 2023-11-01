using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string>? stringInput = new() { "level" };

        // Act
        bool result = Palindrome.IsPalindrome(stringInput);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string>? stringInput = new() { "p" };

        // Act
        bool result = Palindrome.IsPalindrome(stringInput);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string>? stringInput = new() { "peacock" };

        // Act
        bool result = Palindrome.IsPalindrome(stringInput);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string>? stringInput = new() { "leVEl" };

        // Act
        bool result = Palindrome.IsPalindrome(stringInput);

        // Assert
        Assert.IsTrue(result);
    }
}
