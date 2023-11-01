using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;


        // Act & Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = { 1, 3, -9, 10, 4 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { -9, 10, 1, 4, 3 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] inputArray = { 1 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1 }));
    }
}
