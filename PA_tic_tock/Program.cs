using System;
using PA_tic_tock.Clocks;

namespace PA_tic_tock
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockSHop clockSHop = new ClockSHop();
            clockSHop.Run();
        }
    }
}