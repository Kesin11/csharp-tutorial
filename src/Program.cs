using System;

namespace Tutorial
{
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

}