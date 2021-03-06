namespace PA_tic_tock.Clocks
{
    public class BigBen : Clock
    {
        private static BigBen _instance;
        
        protected override string MakeSound()
        {
            return "Big Ben";
        }

        public BigBen(string name) : base(name)
        {
        }

        public BigBen(string name, float delay) : base(name, delay)
        {
        }
    }
}