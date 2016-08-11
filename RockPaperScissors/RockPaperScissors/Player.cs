using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        int score;
        string name;

        public Player()
        {
            
        }
        public int getScore()
        {
            return score;
        }

        public void addOneToScore()
        {
            this.score += 1;
        }
        public void SetName()
        {
            Console.WriteLine("Enter Player Name:");
            name = Console.ReadLine();
        }
        public string getName()
        {
            return this.name;
        }
       
    }
}
