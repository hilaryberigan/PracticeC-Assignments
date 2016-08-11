using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        int round;
        int numberOfRounds;
        public Player playerOne;
        public Player computer;

        public Game()
        {
            this.playerOne = new Player();
            this.computer = new Player();
            this.numberOfRounds = 6;
            this.round = 1;
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to the wonder that is 'Rock, Paper, Scissors'.");
            playerOne.SetName();
            Console.WriteLine("There will be 5 rounds.");


            while (this.round < this.numberOfRounds)
            {
                Console.WriteLine("Welcome to round {0}", this.round);
                Move move = new Move();
                move.MakeMove(playerOne);
                this.round++;
                Console.WriteLine("Press Enter when ready to continue.");
                Console.ReadLine();
                Console.WriteLine("{0} score: {1} ", playerOne.getName(), playerOne.getScore());
                Console.ReadLine();
            }
        }

    }


}
