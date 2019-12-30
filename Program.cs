﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string name = args[0];
        PersonClass person = new PersonClass("john", name);
        Console.WriteLine(person);
        person.Hello();

        // Named argument
        PersonClass namedPerson = new PersonClass(lastName: "john", firstName: name);
        namedPerson.Hello();
    }
}

interface IPerson
{
    string Name();

}
public struct Person : IPerson
{
    string fname, lname;
    public Person(string firstName, string lastName)
    {
        fname = firstName;
        lname = lastName;
    }

    public string Name() => $"{fname} {lname}";
}

interface IPersonClass
{
    string ToString();
    void Hello();
}

public class PersonClass : IPersonClass
{
    private Person person;
    const string hello = "Hello";
    public PersonClass(string firstName, string lastName)
    {
        person = new Person(firstName, lastName);
    }

    public override string ToString() => $"{person.Name()}".Trim();
    public void Hello() => Console.WriteLine($"{hello} {ToString()}");
}
