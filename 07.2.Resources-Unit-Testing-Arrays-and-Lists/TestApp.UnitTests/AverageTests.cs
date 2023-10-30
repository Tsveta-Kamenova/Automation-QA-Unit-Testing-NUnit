using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { Average.CalculateAverage(emptyArray); });

    }

    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { 42, 10, 3, 5 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { 42, -10, 3, 5 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { 42, -10, 3, -5, 5, 10 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(7.5));
    }
}
