using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Radio
{
    public class ClockRadio
    {
        string color;
        public bool isOn;
        bool hasAntenna;
        string size;
        int numberOfButtons;
        bool snoozeIsOn;


        public ClockRadio(string Color, bool IsOn, bool HasAntenna, string Size, int NumberOfButtons, bool SnoozeIsOn)
        {
            color = Color;
            isOn = IsOn;
            hasAntenna = HasAntenna;
            size = Size;
            numberOfButtons = NumberOfButtons;
            snoozeIsOn = SnoozeIsOn;
        }

        public void TurnOff()
        {
            isOn = false;
        }
        public void TurnOn()
        {
            isOn = true;
        }
     }
}
