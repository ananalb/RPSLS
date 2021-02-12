using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameField
    {

        Player player1;
        Player player2;
       

        public GameField()
        {
            
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome! Would you like to face off another human or a computer?");
            Console.WriteLine("1. HUMAN");
            Console.WriteLine("2. COMPUTER");
            string chosenOption = Console.ReadLine();

            switch (chosenOption)
            {
                case "1":
                    player1 = new Human();
                    player2 = new Human();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Computer();
                    break;
                default:
                    Console.WriteLine("Please try again and select an option");
                    break;
            }


        }
        public void DisplayRules()
        {
            Console.WriteLine("Choose rock , paper, scissors, lizard, or spock - the strongest wins!");
        }

        public void CompareGestures(int index, Human human, Computer computer)
        {
            int remainingRounds = 3;

            while (remainingRounds > 0)
               
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                if (human.GestureOptions.Contains("rock"))
                 { 

                
                    Console.WriteLine("Rock crushes Lizard");
                    player1.score++;
                }
                    
                    
            }
            PlayAgain();
            remainingRounds--;

        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            string playAgain = Console.ReadLine();
            playAgain.ToLower();
            if (playAgain == "Yes")
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                //CompareGestures();
                DisplayWinner();
            }
            else
            {
                Console.WriteLine("Thank you for playing");
            }

        }
        public void DisplayWinner()
        {
            
            if (player1.score > player2.score)
            {
                Console.WriteLine("Player one wins");
            }
            else
            {
                Console.WriteLine("Player two wins");
            }
            
           

        }
    }
}


