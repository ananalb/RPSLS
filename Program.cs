using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.ChooseGesture();
            GameField game = new GameField();
            game.Welcome();
            game.DisplayRules();
            
            //game.CompareGestures();
            game.DisplayWinner();
            game.PlayAgain();
            Console.ReadLine();
        }
    }
}
