using ExtensionMethods;
namespace ExtensionTest;
[TestClass]
public sealed class StringExtensionTests
{
    [TestMethod]
    public void TestLeft()
    {
        var str = "Hello, World!";
        Assert.AreEqual("Hello", str.Left(5));
        Assert.AreEqual("Hello, World!", str.Left(20));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Left(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Left(-1));
    }

    [TestMethod]
    public void TestRight()
    {
        var str = "Hello, World!";
        Assert.AreEqual("World!", str.Right(6));
        Assert.AreEqual("Hello, World!", str.Right(20));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Right(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Right(-1));
    }

    [TestMethod]
    public void TestElips()
    {
        var str = "Hello, World!";
        Assert.AreEqual("Hello...", str.Elips(8));
        Assert.AreEqual("Hello++", str.Elips(7,"++"));
        Assert.AreEqual("Hello, World!", str.Elips(20));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Elips(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.Elips(-1));
    }
    [TestMethod]
    public void TestFillLeft()
    {
        var str = "ah";
        Assert.AreEqual("   ah", str.FillLeft(5));
        Assert.AreEqual("a", str.FillLeft(1));
        Assert.AreEqual("###ah", str.FillLeft(5, '#'));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.FillLeft(0, '0'));
    }

    [TestMethod]
    public void TestFillRight()
    {
        var str = "ah";
        Assert.AreEqual("ah   ", str.FillRight(5));
        Assert.AreEqual("h", str.FillRight(1));
        Assert.AreEqual("ah###", str.FillRight(5, '#'));
        Assert.Throws<ArgumentOutOfRangeException>(() => str.FillRight(0, '0'));
    }

    [TestMethod]
    public void TestCleanPath()
    {   
        var str = "L|u\n.d/+i";
        Assert.AreEqual("Lun.d+i", str.CleanPath());
    }
}
