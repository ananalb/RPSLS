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
            Console.WriteLine("1 Rock");
            Console.WriteLine("2 Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");
           
            string chosenOption = Console.ReadLine();
            chosenOption.ToLower();
            
            
                switch (chosenOption)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Please try again and select an option to begin the game");
                        break;
                }
            


        }
    }
}
