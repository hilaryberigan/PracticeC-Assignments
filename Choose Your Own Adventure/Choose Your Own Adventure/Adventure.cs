using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Adventure
    {
        User user;
        public string firstPath;

        Clue clue = new Clue();

        public Adventure(User name)

        {
            this.user = name;
         }

        //Skeleton of Adventure
        public void runAdventure()
        {
            firstPathChoice();
            Console.WriteLine("Oh no! I hear a rustling nearby!");
            clue.chooseClueType();
            getClueChoice();
        }
        
        
        //if Yes, next decision (2)
        public void firstPathChoice()
        {
            Console.WriteLine("There are two paths, one going right and one going forward. The path to the right leads to a lake. The other takes us deep into a forest. Which direction do you think we should go? [Type right or forward].");
            firstPath = Console.ReadLine();

            switch (firstPath)
            {
                case "right":
                    Lake lake = new Lake();
                    Console.WriteLine("We’ve arrived at the lake. I wish I could see! What does it look it like?");
                    lake.chooseLakeColor();
                    lake.chooseLakeSize();
                    break;

                case "forward":
                    Forest forest = new Forest();
                    Console.WriteLine("We've arrived in the forest. I wish I could see! What does it look it like?");
                    forest.chooseTreeColor();
                    forest.chooseTreeType();
                    break;
            }
        }
        //third decision
        public void getClueChoice()
        {
            Console.WriteLine("Quick!! Follow the clues! Where do they lead? [Choose abandoned warehouse or shack]");
            string clueLeadsTo = Console.ReadLine();

            switch (clueLeadsTo)
            {
                case "shack":
                    Shack shack = new Shack();
                    Console.WriteLine("We’ve arrived at the shack. What does it look it like?");
                    shack.chooseShackColor();
                    shack.chooseShackSize();
                    break;

                case "abandoned warehouse":
                    Warehouse warehouse = new Warehouse();
                    Console.WriteLine("We've arrived at the abandoned warehouse. What does it look it like?");
                    warehouse.chooseWarehouseColor();
                    warehouse.chooseWarehouseSize();
                    break;

                default:
                    Console.WriteLine("Are you sure? Let's try again.");
                    getClueChoice();
                    break;
            }
        }

    }
}
