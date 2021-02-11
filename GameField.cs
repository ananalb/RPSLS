using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameField
    {
    }

    public void Welcome()
    {
        Console.WriteLine("Welcome! Would you like to face off another human or a computer?");
        string userInput = Console.ReadLine();
        Console.WriteLine("1. HUMAN");
        Console.WriteLine("2. COMPUTER");
        string chosenOption = Console.ReadLine();

        switch (chosenOption)
        {
            case "1":
                break;
            case "2":
                break;
            default:
                Console.WriteLine("Please try again and select an option");
                break;
        }

        public void DisplayRules()
        {
            Console.WriteLine("Choose rock , paper, scissors, lizard, or spock - the strongest wins!");
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            string playAgain = Console.ReadLine();
            playAgain.ToLower();
            if (playAgain == "YES")
            {

            }
            else
            {

            }


        }
    }
}


