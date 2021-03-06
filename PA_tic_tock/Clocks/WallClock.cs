namespace PA_tic_tock.Clocks
{
    public class WallClock : Clock
    {
        protected override string MakeSound()
        {
            return "Cuckoo";
        }


        public WallClock() : base()
        {
            ClockType = ClockType.WallClock;
        }

        public WallClock(double delay) : base(delay)
        {
            ClockType = ClockType.WallClock;
        }
    }
}