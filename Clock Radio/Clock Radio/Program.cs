using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio fancyClock = new ClockRadio("black", false, false, "12in by 5in", 10, false);
            ClockRadio shabbyClock = new ClockRadio("purple", false, true, "6in by 6in", 2, false);
            fancyClock.TurnOn();

        }
    }
}
