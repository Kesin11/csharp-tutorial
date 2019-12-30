using System;
using Xunit;

namespace Tutorial.Tests
{
    public class PersonTest
    {
        int i;

        public PersonTest()
        {
            i = 1;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, i);

        }


        [Fact]
        public void Test2()
        {
            Assert.Equal(1, i);

        }
    }
}
