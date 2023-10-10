using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player 
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;
    

        //Constructor
        public Player(string name)
        {
            this.name = name;
            //gestures = new List<string> {"rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;

            Player HumanPlayer;
             
              

            List<string> gestures = new List<string>
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock",
            };

            Console.WriteLine(" Player 1: Choose a gesture.");
            string firstGesture = Console.ReadLine();

            string output = string.Join(Environment.NewLine, gestures.ToArray());
            if (firstGesture != output)
            {
                Console.WriteLine("That gesture is invalid");
            }
            
            }
        
        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();

        

        

        
    }
    
}
