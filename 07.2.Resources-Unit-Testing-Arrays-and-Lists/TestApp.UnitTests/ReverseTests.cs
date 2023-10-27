using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] singleElementArray = new int[1] { 42 };
        
        // Act
        string result;
        result = Reverse.ReverseArray(singleElementArray);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] multipleElementArray = new [] { 1, 2, 4};

        // Act
        string result;
        result = Reverse.ReverseArray(multipleElementArray);

        // Assert
        Assert.That(result, Is.EqualTo("4 2 1"));
    }
}
