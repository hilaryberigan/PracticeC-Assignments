using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Move
    { 
        string[] movesArray = new string[3];

        public string GetComputerMove()
        {
            Console.WriteLine("Computer Move:");

            movesArray[0] = "rock";
            movesArray[1] = "paper";
            movesArray[2] = "scissors";

            Random random = new Random();
            string randomMove = movesArray[random.Next(1, 3)];
            Console.WriteLine(randomMove);
            return randomMove;
        }

        public void MakeMove(Player playerOne)
        {
            Console.WriteLine("What is your move? [Rock, Paper, or Scissors]");
            string move = Console.ReadLine();
            move = move.ToLower();

            switch (move)
            {
                case "rock":

                    string computerMove = GetComputerMove();

                    if (computerMove == "rock")
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (computerMove == "paper")
                    {
                        Console.WriteLine("You Lose");
                    }
                    else if (computerMove == "scissors")
                    {
                        Console.WriteLine("You Win");
                        playerOne.addOneToScore();
                    }
                    break;

                case "paper":

                    computerMove = GetComputerMove();
                    
                    if (computerMove == "rock")
                    {
                        Console.WriteLine("You win");
                        playerOne.addOneToScore();
                    }
                    else if (computerMove == "paper")
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (computerMove == "scissors")
                    {
                        Console.WriteLine("You lose");
                    }
                    break;

                case "scissors":

                    computerMove = GetComputerMove();
                    
                    if (computerMove == "rock")
                    {
                        Console.WriteLine("You lose");
                                           }
                    else if (computerMove == "paper")
                    {
                        Console.WriteLine("You win");
                        playerOne.addOneToScore();
                    }
                    else if (computerMove == "scissors")
                    {
                        Console.WriteLine("Tie");
                    }
                    break;
            }

        }
        }   
        }
    

    

