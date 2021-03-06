using System;

namespace PA_tic_tock.Clocks
{
    public enum ClockType
    {
        Watch,
        WallClock,
        AlarmCLock,
        BigBen
    }
    
    public abstract class Clock
    {
        public string Name;
        public ClockType ClockType { get; set; }
        
        protected int Seconds;
        protected int Minutes;
        protected int Hours;
        
        protected DateTime TimeReference;

        protected double Delay;
        
        protected abstract string MakeSound();

        protected Clock()
        {
            Delay = 1;
        }
        
        protected Clock(double delay)
        {
            Delay = delay;
        }

        protected void SetTime(int hours, int minutes, int seconds)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
            
            TimeReference = DateTime.Now;
        }
        
        public string GetTime()
        {
            DateTime currentTime = DateTime.Now;

            var diff = currentTime - TimeReference;

            var totalMilliseconds = diff.TotalMilliseconds * Delay;

            var outputTime = TimeReference.AddMilliseconds(totalMilliseconds);

            return $"{outputTime.Hour.ToString("00")}:{outputTime.Minute.ToString("00")}:{outputTime.Second.ToString("00")}";
        }
    }
}