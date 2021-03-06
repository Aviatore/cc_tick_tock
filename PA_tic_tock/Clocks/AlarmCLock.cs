using System;

namespace PA_tic_tock.Clocks
{
    public class AlarmCLock : Clock
    {
        private string _alarm;
        
        protected override string MakeSound()
        {
            return "Buzz";
        }
        
        public AlarmCLock(string name) : base(name)
        {

        }
        
        public AlarmCLock(string name, float delay) : base(name, delay)
        {

        }
        
        public void SetAlarm(int hours, int minutes, int seconds)
        {
            _alarm = $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
        }

        /*public string TimeLeftToSleep()
        {
            var time = GetTime().Split(':');
            
            
        }*/
    }
}