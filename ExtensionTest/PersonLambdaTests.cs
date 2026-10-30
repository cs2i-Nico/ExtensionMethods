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

        getInfo = person => person.Lastname + " " + person.Firstname;
        Assert.AreEqual("Sez Peggy", getInfo(p));

        getInfo = person => person.ToString();
        Assert.AreEqual("Sez Peggy", getInfo(p));

        getInfo = person => person.Lastname.ToUpper() + " " + person.Firstname;
        Assert.AreEqual("SEZ Peggy", getInfo(p));

        getInfo = person => person.Firstname.Substring(0, 1) + ". " + person.Lastname;
        Assert.AreEqual("P. Sez", getInfo(p));

        p.Birthday = new DateTime(1990, 5, 14);
        getInfo = person => person.Firstname + " a pour nom " + person.Lastname;
        Assert.AreEqual("Peggy a pour nom Sez", getInfo(p));
    }
    
}