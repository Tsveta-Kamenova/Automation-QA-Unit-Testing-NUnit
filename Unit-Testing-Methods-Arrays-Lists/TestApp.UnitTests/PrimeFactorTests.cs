using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long n = 1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { PrimeFactor.FindLargestPrimeFactor(n); });
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long n = 11;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(11));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long n = 777;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(37));
    }
}
