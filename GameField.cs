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

        public void CompareGestures()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                
                player1.ChooseGesture();
                player2.ChooseGesture();

                //if (player1.ChosenGesture == "Rock")
                //{
                //    if (player2.ChosenGesture == "Scissors")
                //    {
                //        player1.score++;
                //    }
                //    else if (player2.ChosenGesture == "Lizard")
                //    {
                //        player1.score++;
                //    }

                //}

                //switch (player1.ChosenGesture)
                //{
                //    case "Rock":
                //        switch (player2.ChosenGesture)
                //        {
                //            case "Rock":
                //                break;

                //            default:
                //                break;
                //        }
                //        break;
                //    case "Paper":
                //        break;
                //    default:
                //        break;
                //}


                if (player1.ChosenGesture == "Rock" && player2.ChosenGesture == "Lizard" )
                { 
                    Console.WriteLine("Rock crushes Lizard");
                    player1.score++;
                }              
               
                else if (player1.ChosenGesture == "Rock" && player2.ChosenGesture == "Scissors")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player1.score++;
                }              
                else if (player1.ChosenGesture == "Paper" && player2.ChosenGesture == "Spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player1.score++;
                }
             
                else if (player1.ChosenGesture == "Paper" && player2.ChosenGesture == "Rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    player1.score++;
                }
                
                else if (player1.ChosenGesture == "Scissors" && player2.ChosenGesture == "Paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player1.score++;
                }
                else if (player1.ChosenGesture == "Scissors" && player2.ChosenGesture == "Lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player1.score++;
                }
                else if (player1.ChosenGesture == "Lizard" && player2.ChosenGesture == "Paper")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player1.score++;
                }
                else if (player1.ChosenGesture == "Lizard" && player2.ChosenGesture == "Spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player1.score++;
                }
                else if (player1.ChosenGesture == "Spock" && player2.ChosenGesture == "Scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player1.score++;
                }
                else if (player1.ChosenGesture == "Spock" && player2.ChosenGesture == "Rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");                   
                    player1.score++;
                }
                else if (player2.ChosenGesture == "Rock" && player1.ChosenGesture == "Scissors")
                {
                    Console.WriteLine("Rock crushes Scissors");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Paper" && player1.ChosenGesture == "Spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    player2.score++;
                }

                else if (player2.ChosenGesture == "Paper" && player1.ChosenGesture == "Rock")
                {
                    Console.WriteLine("Paper covers Rock");
                    player2.score++;
                }

                else if (player2.ChosenGesture == "Scissors" && player1.ChosenGesture == "Paper")
                {
                    Console.WriteLine("Scissors cuts Paper");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Scissors" && player1.ChosenGesture == "Lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Lizard" && player1.ChosenGesture == "Paper")
                {
                    Console.WriteLine("Lizard eats Paper");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Lizard" && player1.ChosenGesture == "Spock")
                {
                    Console.WriteLine("Lizard poisons Spock");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Spock" && player1.ChosenGesture == "Scissors")
                {
                    Console.WriteLine("Spock smashes Scissors");
                    player2.score++;
                }
                else if (player2.ChosenGesture == "Spock" && player1.ChosenGesture == "Rock")
                {
                    Console.WriteLine("Spock vaporizes Rock");
                    player2.score++;
                }

            }          
            

        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            string response = Console.ReadLine();
            int playAgain = Convert.ToInt32(response);
            if (playAgain != 1)
            {
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                player1.score = 0;
                player2.score = 0;
                CompareGestures();
                DisplayWinner();
                PlayAgain();
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


