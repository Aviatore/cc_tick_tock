namespace PA_tic_tock.Clocks
{
    public class WallClock : Clock
    {
        protected override string MakeSound()
        {
            return "Cuckoo";
        }

        public WallClock(string name) : base(name)
        {
        }

        public WallClock(string name, float delay) : base(name, delay)
        {
        }
    }
}