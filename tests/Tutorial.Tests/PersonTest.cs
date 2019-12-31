using Xunit;

namespace Tutorial.Tests
{
  public class PersonTest
  {
    Person person;

    public PersonTest()
    {
      person = new Person("john", "smith");
    }

    [Fact]
    public void Person_Name()
    {
      Assert.Equal("john smith", person.Name());
    }

    [Fact]
    public void Person_fname()
    {
      Assert.Equal("john", person.fname);

    }

    [Fact]
    public void Person_lname()
    {
      Assert.Equal("smith", person.lname);

    }
  }

  public class PersonClassTest
  {
    PersonClass personClass;
    public PersonClassTest()
    {
      personClass = new PersonClass("john", "smith");

    }

    [Fact]
    public void PersonClass_ToString()
    {
      Assert.Equal("john smith", personClass.ToString());
    }
  }
}
