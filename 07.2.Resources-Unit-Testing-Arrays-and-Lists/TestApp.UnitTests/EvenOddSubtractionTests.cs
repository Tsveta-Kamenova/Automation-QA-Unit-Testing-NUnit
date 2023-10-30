using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenArray = new int[2] { 4, 2 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenArray);

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnOddSum()
    {
        // Arrange
        int[] oddArray = new int[3] { 1, 3, 7};

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArray);

        // Assert
        Assert.That(result, Is.EqualTo(11));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] oddArray = new int[5] { 1, 3, 7, 2, 4};

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArray);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
