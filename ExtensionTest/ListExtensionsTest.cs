using ExtensionMethods;
namespace ExtensionTest;
[TestClass]
public sealed class ListExtensionsTest
{
    [TestMethod]
    public void TestFilterList()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var filteredList = list.FilterList(3);
        CollectionAssert.AreEquivalent(new List<int> { 3, 4, 5 }, filteredList);
    }

    [TestMethod]
    public void TestToUpper()
    {
        var list = new List<string> { "test", "tester" };
        var upperList = list.ToUpper();
        CollectionAssert.AreEquivalent(new List<string> { "TEST", "TESTER" }, upperList);
    }

    [TestMethod]

    public void TestToLower()
    {
        var list = new List<string> { "TEST", "TESTER" };
        var lowerList = list.ToLower();
        CollectionAssert.AreEquivalent(new List<string> { "test", "tester" }, lowerList);

        var list2 = new List<string> { "Test", "Tester" };
        var lowerList2 = list2.ToLower();
        CollectionAssert.AreEquivalent(new List<string> { "test", "tester" }, lowerList2);
    }

    [TestMethod]

    public void TestLonguestString()
    {
        var list = new List<string> { "court", "long", "longggggggg" };
        var longestString = list.LonguestString();
        Assert.AreEqual("longggggggg", longestString);
    }

    [TestMethod]
    public void TestShortestString()
    {
        var list = new List<string> { "court", "long", "longggggggg" };
        var shortestString = list.ShortestString();
        Assert.AreEqual("long", shortestString);
        
    }

    [TestMethod]
    public void TestMaxValue()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var maxValue = list.MaxValue();
        Assert.AreEqual(5, maxValue);
    }

    [TestMethod]

    public void TestMinValue()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var minValue = list.MinValue();
        Assert.AreEqual(1, minValue);
    }

    [TestMethod]
    public void TestListTotal()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var total = list.ListTotal();
        Assert.AreEqual(15, total);
    }

    [TestMethod]
    public void TestListAverage()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var average = list.ListAverage();
        Assert.AreEqual(3, average);
    }

    [TestMethod]
    public void TestMaxValue2()
    {

        var list = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = new List<double> { 1.5, 20.2, 35.3, 14.2, 45.1 };
        var list3 = new List<string> { "court", "long", "longggggggg" };
        var list4 = new List<Product> { new Product("A1", "Product 1", 10.0, 5), new Product("A2", "Product 2", 20.0, 3), new Product("A3", "Product 3", 15.0, 7) };
       
        Assert.AreEqual(5, list.MaxValue2());
        Assert.AreEqual(45.1, list2.MaxValue2());
        Assert.AreEqual("longggggggg", list3.MaxValue2());
        Assert.AreEqual(list4[2], list4.MaxValue2());
    }

        [TestMethod]

    public void TestFiltreCriteria()
    {
        var list = new List<string> { "lundi", "mardi", "mercredi", "jeudi","vendredi", "samedi", "dimanche"};
        var expected = new List<string> { "mercredi", "vendredi" };

        CollectionAssert.AreEqual(expected, list.FilterList("re", PositionEnum.Middle));
    }

    [TestMethod]
    public void TestLimit()
    {
        var list = new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi" };
        var expected = new List<string> { "lundi", "mardi" };
        var list2 = new List<int> { 10, 20, 30, 40, 50 };
        var expected2 = new List<int> { 10, 20, 30 };

        CollectionAssert.AreEqual(expected, list.Limit(2));
        CollectionAssert.AreEqual(expected2, list2.Limit(3));
    }

    [TestMethod]
    public void TestFilterListPosition()
    {
        var list = new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
        CollectionAssert.AreEqual(new List<string> { "lundi" }, list.FilterList("lu", PositionEnum.Start));
        CollectionAssert.AreEqual(new List<string> { "mercredi", "vendredi" }, list.FilterList("re", PositionEnum.Middle));
    }
    [TestMethod]
    public void TestFilterListLongueur()
    {
        var list = new List<string> { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
        CollectionAssert.AreEqual(new List<string> { "lundi", "mardi", "jeudi" }, list.FilterList("lu", PositionEnum.Start, 5));
    }

}