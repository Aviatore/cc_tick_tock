namespace PA_tic_tock.Clocks
{
    public class BigBen : Clock
    {
        private static BigBen _instance;
        
        protected override string MakeSound()
        {
            return "Big Ben";
        }

        public BigBen() : base()
        {
            ClockType = ClockType.BigBen;
        }

        public BigBen(double delay) : base(delay)
        {
            ClockType = ClockType.BigBen;
        }
    }
}