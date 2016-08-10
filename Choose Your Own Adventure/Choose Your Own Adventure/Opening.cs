using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Opening
    {
        User user = new User();

        public Opening(User name)
        {
            this.user = name;
        }
        public void runOpening()
        {
            user.enterName();
            Console.WriteLine("Hello {0}! I'm so glad to see you! I've come across some trouble and need your help. Someone has stolen my Crystal of Immortality. I have been carrying it for so long, without it my life will be cut very short. I can already feel the end drawing near and my sight is failing. You must lead me through the dangerous lands of Fourth Wardington to find the theif and retrieve my crystal.", user.getName());
             getHelpChoice();
        }
        public void getHelpChoice()
        {
            Console.WriteLine("Will you help me? [yes or no]");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "yes":
                    Console.WriteLine("Thank you so much!");
                    Adventure adventure = new Adventure(user);
                    adventure.runAdventure();
                    break;

                case "no":
                    Console.WriteLine("OOOOHHHHH NOOOOOOOOO!!!!!   Game Over....");
                    break;

                default:
                    Console.WriteLine("What was that? You've got to be sure on this.");
                    getHelpChoice();
                    break;
            }
         }
     }
 }
