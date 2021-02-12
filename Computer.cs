using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    
    {
        Random rand; 
        public Computer()
        {
            rand = new Random();
        }

        public override void ChooseGesture()
        {

            //randomly getting gesture
            int gesture = rand.Next(GestureOptions.Count);
            Console.WriteLine(GestureOptions[gesture]);
            ChosenGesture = GestureOptions[gesture];
            Console.ReadLine();



        }
    }
}
