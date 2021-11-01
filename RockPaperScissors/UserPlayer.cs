using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors! Please enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name + "!");
            Console.WriteLine();
        }

        public override RPSEnum GetRPS()
        {

            Console.WriteLine("Please select r for rock, p for paper or s for scissors:");
            string answer = Console.ReadLine();

            switch (answer)
            {

                case "r":
                    Console.WriteLine("You selected rock!");
                    return RPSEnum.Rock;

                case "p":
                    Console.WriteLine("You selected paper!");
                    return RPSEnum.Paper;

                case "s":
                    Console.WriteLine("You selected scissors!");
                    return RPSEnum.Scissors;

                default:
                    Console.WriteLine("I'm sorry I don't understand your input lets try again");
                    return GetRPS();


            }


        }

        public string GetOpponent()
        {

            Console.WriteLine("Please select you opponent. Enter 1 for Randa and 2 for Rocky: ");
            string opponentChoice = Console.ReadLine();

            switch (opponentChoice)
            {
                case "1":
                    Console.WriteLine("Your opponent is Randa!");
                    return opponentChoice;

                case "2":
                    Console.WriteLine("Your opponent is Rocky!");
                    return opponentChoice;
                    
                default:
                    Console.WriteLine("I'm sorry I don't understand your input lets try again");
                    return opponentChoice;

            }
        }




    }
    
}
    




//then displays their choice and their opponents choice and the result(who wins) 



//continue until the user doesn't want to play anymore
//error message until the user makes a valid selection