using System;

namespace Exercises_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // store match history info
            MatchHistory newGame = new MatchHistory();

            //starts the game
            Menu(newGame);
        }

        static void Menu(MatchHistory game)
        {
            Console.WriteLine("Select Option: (1, 2, 3)");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Stats");
            Console.WriteLine("3 - Exit");

            string menuAction = Console.ReadLine();

            //menu options
            switch(menuAction)
            {
                //play option
                case "1":
                    Play(game);
                    break;
                // check stats option
                case "2":
                    Stats(game);
                    break;
                // close game
                case "3":
                    Console.WriteLine("Have a nice day!");
                    return;
                    break;
                //Invalid input call ask the user to input again
                default:
                    Console.WriteLine("Error! Wrong input!\n");
                    Menu(game);
                    break;
            }
        }


        static void Play(MatchHistory game)
        {
            RockPaperScissorsEnum playerMove = GetUserMove();

            RockPaperScissorsEnum computerMove = GetComputerMove();

            Console.WriteLine($"Player Move: {playerMove}");

            Console.WriteLine($"Computer Move: {computerMove}");

            GetWinner(playerMove, computerMove, game);

            Console.WriteLine("Pres Enter to continue");
            Console.ReadLine();

            Menu(game);

        }

        static void Stats(MatchHistory game)
        {
            game.ShowStats();

            Console.WriteLine("Pres Enter to continue");
            Console.ReadLine();

            Menu(game);

        }

        //Compares the player and the computer moves
        private static void GetWinner(RockPaperScissorsEnum playerMove, RockPaperScissorsEnum computerMove, MatchHistory game)
        {
           if(playerMove == computerMove)
            {
                Console.WriteLine("Draw");
                game.Draw();
            }
           else if (playerMove == RockPaperScissorsEnum.Rock)
            {
                if(computerMove == RockPaperScissorsEnum.Paper)
                {
                    Console.WriteLine("Computer Wins");
                    game.ComputerWins++;
                }
                else
                {
                    Console.WriteLine("Player Wins");
                    game.PlayerWins++;
                }
            }
           else if (playerMove == RockPaperScissorsEnum.Paper)
            {
                if (computerMove == RockPaperScissorsEnum.Scissors)
                {
                    Console.WriteLine("Computer Wins");
                    game.ComputerWins++;
                }
                else
                {
                    Console.WriteLine("Player Wins");
                    game.PlayerWins++;
                }
            }
           else
            {
                if (computerMove == RockPaperScissorsEnum.Rock)
                {
                    Console.WriteLine("Computer Wins");
                    game.ComputerWins++;
                }
                else
                {
                    Console.WriteLine("Player Wins");
                    game.PlayerWins++;
                }
            }
        }

        //get a random move for the computer
        static RockPaperScissorsEnum GetComputerMove()
        {
            Random rnd = new Random();
            int move = rnd.Next(1, 13);

            switch (move)
            {
                case 1:
                    return RockPaperScissorsEnum.Rock;
                    break;
                case 2:
                    return RockPaperScissorsEnum.Paper;
                    break;
                case 3:
                    return RockPaperScissorsEnum.Scissors;
                    break;
                default:
                    return GetComputerMove();
                    break;
            }
        }

        //ask the user for a valid move
        static RockPaperScissorsEnum GetUserMove()
        {
            Console.WriteLine("Pick Your Move: (1, 2, 3)");
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");

            string playerMove = Console.ReadLine();

            switch (playerMove)
            {
                case "1":
                    return RockPaperScissorsEnum.Rock;
                    break;
                case "2":
                    return RockPaperScissorsEnum.Paper;
                    break;
                case "3":
                    return RockPaperScissorsEnum.Scissors;
                    break;
                default:
                    return GetUserMove();
                    break;
            }
        }

    }
}
