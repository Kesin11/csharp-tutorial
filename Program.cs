using System;

class Program
{
    static void Main(string[] args)
    {
        string name = args[0];
        Person person = new Person("john", name);
        Console.WriteLine(person);
        person.DisplayName();
    }
}

public class Person
{
    private string fname;
    private string lname;
    public Person(string firstName, string lastName)
    {
        fname = firstName;
        lname = lastName;
    }

    public override string ToString() => $"{fname} {lname}".Trim();
    public void DisplayName() => Console.WriteLine(ToString());
}
