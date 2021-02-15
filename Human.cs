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
            Console.WriteLine("Select your gesture from the list below:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");

            string chosenOption = Console.ReadLine();

            switch (chosenOption)
            {
                case "1":
                    ChosenGesture = GestureOptions[0];
                    Console.WriteLine("You chose rock");
                    break;
                case "2":
                    ChosenGesture = GestureOptions[1];
                    Console.WriteLine("You chose paper");
                    break;
                case "3":
                    ChosenGesture = GestureOptions[2];
                    Console.WriteLine("You chose scissors");
                    break;
                case "4":
                    ChosenGesture = GestureOptions[3];
                    Console.WriteLine("You chose lizard");
                    break;
                case "5":
                    ChosenGesture = GestureOptions[4];
                    Console.WriteLine("You chose spock"); 
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;

            }

        }
    }
}

