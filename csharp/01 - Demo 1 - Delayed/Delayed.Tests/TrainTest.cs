using Xunit;
using FluentAssertions;

namespace Delayed.Tests {
    public class TrainTest {

        private Train _train;

        public TrainTest() {
            _train = new Train();
        }
        
        [Fact] 
        public void Delay_HoursDelayedIsSet()
        {
            _train.Delay(2);

            _train.HoursDelayed.Should().Be(2);
        }
    }
}