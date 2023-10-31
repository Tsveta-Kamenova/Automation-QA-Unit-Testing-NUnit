using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> checkList = new() { 1 };

        // Act
        int result = MaxNumber.FindMax(checkList);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> checkList = new() { 1, 5, 19999 };

        // Act
        int result = MaxNumber.FindMax(checkList);

        // Assert
        Assert.That(result, Is.EqualTo(19999));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> checkList = new() { -1, -5, -19999 };

        // Act
        int result = MaxNumber.FindMax(checkList);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> checkList = new() { -1, -5, -19999, 7, 500 };

        // Act
        int result = MaxNumber.FindMax(checkList);

        // Assert
        Assert.That(result, Is.EqualTo(500));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> checkList = new() { -1, -5, -19999, 7, 500, 500, 500, 7 };

        // Act
        int result = MaxNumber.FindMax(checkList);

        // Assert
        Assert.That(result, Is.EqualTo(500));
    }
}
