using ExtensionMethods;
namespace ExtensionTest;

[TestClass]
public sealed class LambdaTests
{

    [TestMethod]
    public void TestRectangleArea()
    {
        Func<double, double, double> rectangleArea = (width, height) => width * height;

        Assert.AreEqual(12, rectangleArea(3, 4));
        Assert.AreEqual(7.5, rectangleArea(2.5, 3));
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        Func<double, double, double> rectanglePerimeter = (width, height) => (width + height) * 2;

        Assert.AreEqual(14, rectanglePerimeter(3, 4));
        Assert.AreEqual(11, rectanglePerimeter(2.5, 3));
    }

    [TestMethod]
    public void TestIsEven()
    {
        Func<int, bool> isEven = n => n % 2 == 0;

        Assert.IsTrue(isEven(4));
        Assert.IsFalse(isEven(7));
    }

    [TestMethod]
    public void TestIsOdd()
    {
        Func<int, bool> isOdd = n => n % 2 != 0;

        Assert.IsTrue(isOdd(7));
        Assert.IsFalse(isOdd(4));
    }

    [TestMethod]
    public void TestIsDivisibleBy()
    {
        Func<int, int, bool> isDivisibleBy = (n, divisor) => n % divisor == 0;

        Assert.IsTrue(isDivisibleBy(15, 5));
        Assert.IsFalse(isDivisibleBy(15, 4));
    }

    [TestMethod]
    public void TestHelloWorld()
    {
        Func<string> helloWorld = () => "Hello World!";

        Assert.AreEqual("Hello World!", helloWorld());
    }


    private List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product("P1", "Clavier", 50, 10),
            new Product("P2", "Ordinateur", 900, 3),
            new Product("P3", "Souris", 25, 20),
            new Product("P4", "Écran", 350, 5),
        };
    }

    [TestMethod]
    public void TestOrderBy()
    {
        var products = GetProducts();

        var sorted = products.OrderBy(p => p.Price).ToList();

        var expected = new List<Product> { products[2], products[0], products[3], products[1] };
        CollectionAssert.AreEqual(expected, sorted);
    }

    [TestMethod]
    public void TestWhere()
    {
        var products = GetProducts();

        var filtered = products.Where(p => p.Price > 300).ToList();

        var expected = new List<Product> { products[1], products[3] };
        CollectionAssert.AreEqual(expected, filtered);
    }

}