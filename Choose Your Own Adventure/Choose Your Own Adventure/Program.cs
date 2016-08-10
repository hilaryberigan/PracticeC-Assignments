using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Opening opening = new Opening(user);
            opening.runOpening();
            Console.WriteLine("The End");
            Console.ReadLine();

        }


                
            }
   
            

        
    }

