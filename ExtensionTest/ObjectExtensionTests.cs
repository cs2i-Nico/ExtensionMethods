using ExtensionMethods;
namespace ExtensionTest;

[TestClass]
public sealed class ObjectExtensionTests
{
    // Mêmes tests que la lambda getInfo, sur Person
    [TestMethod]
    public void TestGetInformationPerson()
    {
        var p = new Person("Sez", "Peggy");

        Assert.AreEqual("Sez", p.GetInformation(person => person.Lastname));

        Assert.AreEqual("Peggy", p.GetInformation(person => person.Firstname));

        Assert.AreEqual("Sez Peggy", p.GetInformation(person => person.Lastname + " " + person.Firstname));
        Assert.AreEqual("Sez Peggy", p.GetInformation(person => person.ToString()));
        Assert.AreEqual("SEZ Peggy", p.GetInformation(person => person.Lastname.ToUpper() + " " + person.Firstname));

        Assert.AreEqual("P. Sez", p.GetInformation(person => person.Firstname.Substring(0, 1) + ". " + person.Lastname));
    }

    [TestMethod]
    public void TestGetInformationProduct()
    {
        var product = new Product("P1", "Clavier", 50, 10);

        Assert.AreEqual("P1", product.GetInformation(pr => pr.Id));

        Assert.AreEqual("Clavier", product.GetInformation(pr => pr.Name));
 
        Assert.AreEqual("P1 Clavier", product.GetInformation(pr => pr.Id + " " + pr.Name));

        Assert.AreEqual("CLAVIER", product.GetInformation(pr => pr.Name.ToUpper()));

        Assert.AreEqual("Stock : 500", product.GetInformation(pr => "Stock : " + (pr.Price * pr.Quantity)));
    }
}