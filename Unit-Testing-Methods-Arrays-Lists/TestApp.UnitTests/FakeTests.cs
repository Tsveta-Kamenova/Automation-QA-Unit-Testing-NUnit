using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { Fake.RemoveStringNumbers(input); });
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[]? inputArray = { '3', 'a', '$' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 'a', '$' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[]? inputArray = { '@', 'a', '$' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { '@', 'a', '$' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_OnlyDigitsArray_ReturnsEmptyArray()
    {
        // Arrange
        char[]? inputArray = { '3', '1', '8' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
