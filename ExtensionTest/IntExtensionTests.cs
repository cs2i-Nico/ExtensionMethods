using ExtensionMethods;
namespace ExtensionTest;
[TestClass]
public sealed class IntExtensionTests
{
    [TestMethod]
    public void TestIsEven()
    {
        var x = 12;
        Assert.IsTrue(x.IsEven());

        var y = 13;
        Assert.IsFalse(y.IsEven());
    }

    [TestMethod]
    public void TestIsOdd()
    {
        var x = 13;
        Assert.IsTrue(x.IsOdd());

        var y = 12;
        Assert.IsFalse(y.IsOdd());
    }

    [TestMethod]
    public void TestIsDivisibleBy()
    {
        var x = 100;
        Assert.IsTrue(x.IsDivisibleBy(25));
        Assert.IsFalse(x.IsDivisibleBy(3));
    }
}
