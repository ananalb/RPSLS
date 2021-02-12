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
            rand.Next(GestureOptions.Count);
            Console.WriteLine(GestureOptions[0]);
            Console.WriteLine(GestureOptions[1]);
            Console.WriteLine(GestureOptions[2]);
            Console.WriteLine(GestureOptions[3]);
            Console.WriteLine(GestureOptions[4]);
            Console.ReadLine();



        }
    }
}
