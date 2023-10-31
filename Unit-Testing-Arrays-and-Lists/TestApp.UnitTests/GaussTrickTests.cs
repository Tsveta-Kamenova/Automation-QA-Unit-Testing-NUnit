using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> checkList = new() { 1 };

        // Act
        List<int> result = GaussTrick.SumPairs(checkList);

        // Assert
        CollectionAssert.AreEqual(checkList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6};

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);
        List<int> resultList = new() { 7, 7, 7 };

        // Assert
        CollectionAssert.AreEqual(resultList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);
        List<int> resultList = new() { 6, 6, 3 };

        // Assert
        CollectionAssert.AreEqual(resultList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 15, 17 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);
        List<int> resultList = new() { 18, 17, 16, 16, 15, 15, 15 };

        // Assert
        CollectionAssert.AreEqual(resultList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 15, 17, 20 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);
        List<int> resultList = new() { 21, 19, 18, 17, 17, 16, 16, 8};

        // Assert
        CollectionAssert.AreEqual(resultList, result);
    }
}
