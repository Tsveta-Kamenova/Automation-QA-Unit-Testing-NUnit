using NUnit.Framework;
public class SummatorTests
{

    [Test]
    public void Test_SumTwoNumbers()
    {
        // Arrange
        int[] nums = new[] { 3, 5 };

        // Act
        int sum = Summator.Sum(nums);

        // Assert
        Assert.AreEqual(8, sum);

    }

    [Test]
    public void Test_SumThreeNumbers()
    {
        // Arrange
        int[] nums = new[] { 3, 5, 4};

        // Act
        int sum = Summator.Sum(nums);

        // Assert
        Assert.AreEqual(12, sum);

    }
}
