namespace Delayed {
    public class Train {
        
        public void Delay(int hoursDelayed) => HoursDelayed = hoursDelayed;
        public int HoursDelayed { get; private set;}
    }
}