using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = { 1, 3, 5, 7};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = { 1, 3, 3, 3, 5, 5, 7 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        int[] noDuplicates = { 1, 3, 5, 7 };

        // Assert
        Assert.That(result, Is.EqualTo(noDuplicates));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = { 3, 3, 3 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        int[] onlyDuplicates = { 3 };

        // Assert
        Assert.That(result, Is.EqualTo(onlyDuplicates));
    }
}
