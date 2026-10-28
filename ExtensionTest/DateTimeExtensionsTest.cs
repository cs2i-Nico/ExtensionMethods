using ExtensionMethods;
namespace ExtensionTest;
[TestClass]
public sealed class DateTimeExtensionsTest
{
    [TestMethod]
    public void TestToIso8601()
    {
        var date = new DateTime(2026, 3, 5);
        Assert.AreEqual("2026-03-05", date.ToIso8601());
    }

    [TestMethod]
    public void TestIsBetween()
    {
        var date1 = new DateTime(2026, 1, 1);
        var date2 = new DateTime(2026, 12, 31);

        Assert.IsTrue(new DateTime(2026, 6, 15).IsBetween(date1, date2));
        Assert.IsFalse(new DateTime(2025, 12, 31).IsBetween(date1, date2));
        Assert.IsFalse(new DateTime(2027, 1, 1).IsBetween(date1, date2));
    }

     [TestMethod]
    public void TestIsWeekDay()
    {
        Assert.IsTrue(new DateTime(2026, 10, 26).IsWeekDay());
        Assert.IsTrue(new DateTime(2026, 10, 30).IsWeekDay());
        Assert.IsFalse(new DateTime(2026, 10, 31).IsWeekDay());
    }

    [TestMethod]
    public void TestIsWeekEnd()
    {
        Assert.IsTrue(new DateTime(2026, 10, 31).IsWeekEnd());
        Assert.IsTrue(new DateTime(2026, 11, 1).IsWeekEnd());
        Assert.IsFalse(new DateTime(2026, 10, 28).IsWeekEnd());
    }

    [TestMethod]
    public void TestIsLeapYear()
    {
        Assert.IsTrue(new DateTime(2024, 1, 1).IsLeapYear());
        Assert.IsTrue(new DateTime(2400, 1, 1).IsLeapYear());
        Assert.IsFalse(new DateTime(2023, 1, 1).IsLeapYear());
        Assert.IsFalse(new DateTime(1900, 1, 1).IsLeapYear());
    }

}
