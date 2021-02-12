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
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
           
            string chosenOption = Console.ReadLine();
            chosenOption.ToLower();
            
            
                switch (chosenOption)
                {
                    case "Rock":
                    ChosenGesture = GestureOptions[0];
                        break;
                    case "Paper":
                    ChosenGesture = GestureOptions[1];
                    break;
                    case "Scissors":
                    ChosenGesture = GestureOptions[2];
                    break;
                    case "Lizard":
                    ChosenGesture = GestureOptions[3];
                    break;
                    case "Spock":
                    ChosenGesture = GestureOptions[4];
                    break;
                    default:
                        Console.WriteLine("Please try again and select an option to begin the game");
                        break;
                }
        }
    }
}
