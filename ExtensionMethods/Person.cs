namespace ExtensionMethods;

public class Person
{
    public DateTime Birthday { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public Person(string lastname, string firstname)
    {
        this.Lastname = lastname;
        this.Firstname = firstname;
    }

    public override string ToString()
    {
        return Lastname + " " + Firstname;
    }
}