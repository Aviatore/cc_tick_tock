namespace PA_tic_tock.Clocks
{
    public class Watch : Clock
    {
        public string Color { get; }
        
        protected override string MakeSound()
        {
            return "Tick Tock";
        }

        public Watch(string name, string color) : base(name)
        {
            Color = color;
        }
        
        public Watch(string name, string color, float delay) : base(name, delay)
        {
            Color = color;
        }
    }
}