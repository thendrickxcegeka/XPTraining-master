using System;
using Xunit;
using FluentAssertions;

namespace VampireSlayer.Tests
{
    public class HunterTest
    {
        [Fact]
        public void CanHunt_GivenDayTime_ThenCannotHunt()
        {
            Hunter hunter = new Hunter();
            hunter.CanHunt(new DateTime(2014, 4, 12, 16, 1, 0)).Should().BeFalse();
        }

        [Fact]
        public void CanHunt_GivenNightTime_ThenCanHunt()
        {
            Hunter hunter = new Hunter();

            hunter.CanHunt(new DateTime(2014, 4, 12, 1, 1, 0)).Should().BeTrue();
        }
        
    }
}
