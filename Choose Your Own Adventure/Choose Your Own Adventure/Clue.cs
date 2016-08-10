using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Clue
    {
        string clueType;

        public void chooseClueType()
        {

            Console.WriteLine("Look around what clue do you see? [Choose footprints or broken branches]");
            clueType = Console.ReadLine();
        }

        public string getClueType()
        {
            return this.clueType;
        }
    }
}

    



