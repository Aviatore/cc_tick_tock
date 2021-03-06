namespace PA_tic_tock.Clocks
{
    public class Watch : Clock
    {
        public string Color { get; }
        
        protected override string MakeSound()
        {
            return "Tick Tock";
        }

        public Watch(string color) : base()
        {
            ClockType = ClockType.Watch;
            
            Color = color;
        }
        
        public Watch(string color, double delay) : base(delay)
        {
            ClockType = ClockType.Watch;
            
            Color = color;
        }
    }
}