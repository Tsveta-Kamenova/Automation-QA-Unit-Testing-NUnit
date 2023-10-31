using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noAdjacentEqualsList = new() { 1, 2, 3, 4, 5};

        // Act
        string result = AdjacentEqual.Sum(noAdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> AdjacentEqualsList = new() { 1, 1, 3, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(AdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("2 6 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> AdjacentEqualsList = new() { 1, 1, 1, 1 };

        // Act
        string result = AdjacentEqual.Sum(AdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> AdjacentEqualsList = new() { 1, 1, 5, 7, 253 };

        // Act
        string result = AdjacentEqual.Sum(AdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("2 5 7 253"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> AdjacentEqualsList = new() { 5, 7, 253, 1, 1 };

        // Act
        string result = AdjacentEqual.Sum(AdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("5 7 253 2"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> AdjacentEqualsList = new() { 5, 7, 253, 253, 1, 2 };

        // Act
        string result = AdjacentEqual.Sum(AdjacentEqualsList);

        // Assert
        Assert.That(result, Is.EqualTo("5 7 506 1 2"));
    }
}
