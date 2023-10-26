using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_AdditionPositiveNumbers()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.Greater(actual, 0);
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_AdditionNegativeNumbers()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(-5, -2);

        // Assert
        Assert.Less(actual, 0);
        Assert.AreEqual(-7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_SubtractionPositiveNumbers()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Subtraction(5, 2);

        // Assert
        Assert.AreEqual(3, actual, "Subtraction did not work properly.");
    }


    [Test]
    public void Test_SubtractionNegativeNumbers()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Subtraction(-5, -2);

        // Assert
        Assert.AreEqual(-3, actual, "Subtraction did not work properly.");
    }
}
