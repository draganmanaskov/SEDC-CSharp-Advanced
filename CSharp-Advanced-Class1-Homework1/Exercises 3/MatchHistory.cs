using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_3
{
    public class MatchHistory
    {
        private int _gamesPlayed = 0;

        private int _playerWins = 0;

        private int _computerWins = 0;


        public int PlayerWins {
            get
            {
                return _playerWins;
            }
            set
            {
                //the value when setting doesnt matter
                _gamesPlayed++;
                _playerWins++;
            }
        }

        public int ComputerWins { 
            get
            {
                return _computerWins;
            }
            set
            {
                //the value when setting doesnt matter
                _gamesPlayed++;
                _computerWins++;
            }
        }

        public void Draw()
        {
            //if we get a draw we use this to increment the games played
            _gamesPlayed++;
        }

        public void ShowStats()
        {
            Console.WriteLine("Match History Stats\n");
            Console.WriteLine($"Games Played: {_gamesPlayed}");
            Console.WriteLine($"Player Wins: {PlayerWins}");
            Console.WriteLine($"Computer Wins: {ComputerWins}");

            if(_gamesPlayed == 0)
            {
                Console.WriteLine("Player win%: 0%");
            }
            else
            {   
                Console.WriteLine("Plater win%: {0:0.00}%", (double)(((100f * PlayerWins) / _gamesPlayed)));
            }
        }

    }
}
