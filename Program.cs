using System;

class Program
{
    static void Main(string[] args)
    {
        string name = args[0];
        PersonClass person = new PersonClass("john", name);
        Console.WriteLine(person);
        person.DisplayName();
    }
}

public struct Person
{
    string fname;
    string lname;
    public Person(string firstName, string lastName)
    {
        fname = firstName;
        lname = lastName;
    }

    public string Name() => $"{fname} {lname}";
}

public class PersonClass
{
    private Person person;
    public PersonClass(string firstName, string lastName)
    {
        person = new Person(firstName, lastName);
    }

    public override string ToString() => $"{person.Name()}".Trim();
    public void DisplayName() => Console.WriteLine(ToString());
}
