using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Shack
    {
        string shackSize;
        string shackColor;

        public void chooseShackSize()
        {
            Console.WriteLine("How big is the shack? [small or very small]");
            shackSize = Console.ReadLine();
        }

        public void chooseShackColor()
        {
            Console.WriteLine("What color is the shack? [choose any color]");
            shackColor = Console.ReadLine();
        }
        public string getShackSize()
        {
            return this.shackSize;
        }
        public string getShackColor()
        {
            return this.shackColor;
        }
    }
}
