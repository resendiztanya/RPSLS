using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            return 0;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            //Step 1: Introduce RPSLS Game. Explain and list rules of the game. 
            WelcomeMessage();
            Console.WriteLine("-Rock crushes Scissors -Scissors cuts paper -Paper cover Rock " +
                "-Rock crushes Lizard -Lizard poisons spock -Spock smashes scissors " +
                "-Scissors decapitates Lizard -Lizard eats Paper -Paper disproves Spock " +
                "-Spock vaporizes Rock");

            Console.WriteLine("The winner of 2 out of 3 rounds will be declared the final " +
                "winner between 2 players.");

            //Step 2: Ask if there will be 1 or 2 human players participating in the game 
            int singlePlayer = 1;
            int numberofPlayers = 2;
            Console.WriteLine("How many human players will be playing, 1 or 2?");
            string numberofHumanPlayersInput = "1";

            int val = 0;
            Int32.TryParse(numberofHumanPlayersInput, out val);

            numberofHumanPlayersInput = Console.ReadLine();

            if (val == numberofPlayers)
            {
                
                Console.WriteLine("Player 1 vs. Player 2 will now commence, enter Player 1 name");
                string playerOneName = Console.ReadLine();
            }
            else if (val == singlePlayer)
            {
                Console.WriteLine("Player 1 vs. Computer will now commence.");
            }
            //Step 3: 1st round will begin and a gesture will be decided upon by each player
            

                //Step 4: "winner" or "tie" and score will be displayed at the end of each round
                //step 5: Final score will be displayed after 2 rounds have been won by a player 
                //step 6: Game will reset 

            }
    }
}
