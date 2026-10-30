using ExtensionMethods;
namespace ExtensionTest;

[TestClass]
public sealed class PersonLambdaTests
{
    [TestMethod]
    public void TestGetLastname()
    {
        var p = new Person("Sez", "Peggy");
        Func<Person, string> getLastname = person => person.Lastname;

        Assert.AreEqual("Sez", getLastname(p));
    }
    [TestMethod]
    public void TestGetFirstname()
    {
        var p = new Person("Sez", "Peggy");
        Func<Person, string> getFirstname = person => person.Firstname;

        Assert.AreEqual("Peggy", getFirstname(p));
    }

    [TestMethod]
    public void TestGetInfo()
    {
        var p = new Person("Sez", "Peggy");
        Func<Person, string> getInfo;

        getInfo = person => person.Lastname;
        Assert.AreEqual("Sez", getInfo(p));

        getInfo = person => person.Firstname;
        Assert.AreEqual("Peggy", getInfo(p));

    }
    
}