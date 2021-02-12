using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override void ChooseGesture()
        {
            //user input for gesture
            Console.WriteLine("Select your gesture from the list below");
            GiveOptions();
            string chosenOption = Console.ReadLine();
            chosenOption.ToLower();
            switch (chosenOption)
            {
                case "Rock":                   
                    break;
                case "Paper":
                    break;
                case "Scissors":
                    break;
                case "Lizard":
                    break;
                case "Spock":
                    break;
                default:
                    Console.WriteLine("Please try again and select an option to begin the game");
                    break;
            }


        }
    }
}
