using System;
using System.Collections.Generic;
using PA_tic_tock.Clocks;
using System.Threading;

namespace PA_tic_tock
{
    public class ClockSHop
    {
        private List<Clock> _clocks;

        public ClockSHop()
        {
            ClockFactory clockFactory = new ClockFactory();
            _clocks = clockFactory.GenerateClocks(2, 0, 1);
        }

        public void Run()
        {
            bool loop = true;
            
            while(loop)
            {
                foreach (var clock in _clocks)
                {
                    Console.WriteLine(clock.GetTime());
                }
                
                Thread.Sleep(1000);
            }
        }
    }
}