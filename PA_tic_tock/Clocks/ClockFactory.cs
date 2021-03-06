using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace PA_tic_tock.Clocks
{
    public class ClockFactory
    {
        public List<Clock> GetClock<T>(int quantity, string name, double delay=1) where T : Clock
        {
            List<Clock> clocks = new List<Clock>();

            for (int i = 0; i < quantity; i++)
            {
                clocks.Add(typeof(T) switch
                {
                    Watch => Activator.CreateInstance(typeof(T), new {name, delay}) as T,
                });
                
                var paramteres = new object[2] {name, delay};
                clocks.Add(Activator.CreateInstance(typeof(T), paramteres) as T);
            }

            return clocks;
        }

        public List<Clock> GenerateClocks(int wallClockquantity, int watchClockQuantity, int AlarmCLockQuantity)
        {
            List<Clock> clocks = new List<Clock>();
            clocks.AddRange(GetClock<WallClock>(wallClockquantity, "WallClock", 1));
            clocks.AddRange(GetClock<AlarmCLock>(AlarmCLockQuantity, "Alarm Clock", 1));
            clocks.AddRange(GetClock<Watch>(watchClockQuantity, "Watch", 1));
            clocks.AddRange(GetClock<BigBen>(1, "BigBen", 1));

            return clocks;
        }
    }
}