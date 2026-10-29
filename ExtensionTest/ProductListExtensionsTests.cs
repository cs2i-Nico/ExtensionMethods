using ExtensionMethods;
namespace ExtensionTest;
[TestClass]
public sealed class ProductListExtensionsTests
{
    private List<Product> list;

    private Product product1, product2, product3;

    [TestInitialize]
    public void Initialize()
    {
        product1 = new Product("A1", "Product 1", 10.0, 5);
        product2 = new Product("A2", "Product 2", 20.0, 3);
        product3 = new Product("A3", "Product 3", 15.0, 7);

        list = new List<Product> { product1, product2, product3 };
    }

    [TestMethod]
    public void TestStockQuantity()
    {
        
        var totalQuantity = list.StockQuantity();
        Assert.AreEqual(15, totalQuantity);
    }

    [TestMethod]

    public void TestAveragePrice()
    {

        var averagePrice = list.AveragePrice();

        Assert.AreEqual(15.0, averagePrice);
    }
    [TestMethod]
    public void TestStockValue()
    {

        var totalStockValue = list.StockValue();

        Assert.AreEqual(215.0, totalStockValue);
    }
    [TestMethod]
    public void TestMaxPrice()
    {

        var maxPrice = list.MaxPrice();

        Assert.AreEqual(20.0, maxPrice);
    }
    [TestMethod]
    public void TestMinPrice()
    {
        var minPrice = list.MinPrice();

        Assert.AreEqual(10.0, minPrice);
    }
}