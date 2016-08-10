using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class User
    {
        public string name;
       
       
        public void enterName()
        {
            Console.WriteLine("What is your name?");
            this.name = Console.ReadLine();
        }
        public string getName()
        {
            return this.name;
        }

        

        }

    }
