using Xunit;
using FluentAssertions;

namespace Greeting.Test
{

    public class GreetingTest
    {
        private Greeting _greeting;

        public GreetingTest()
        {
            _greeting = new Greeting();
        }

        [Fact]
        public void Morning() => _greeting.GetGreeting.Should().Be("Good morning");

        [Fact]
        public void Evening() => _greeting.GetGreeting.Should().Be("Good Evening");
    }
}