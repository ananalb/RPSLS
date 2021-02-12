using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public List<string> GestureOptions;
        public int score;
        public Player()
        {
            GestureOptions = new List<string>();
            score = 0;
        }

        public abstract void ChooseGesture();

        public void GiveOptions()
        {
            GestureOptions.Add("Rock");
            GestureOptions.Add("Paper");
            GestureOptions.Add("Scissors");
            GestureOptions.Add("Lizard");
            GestureOptions.Add("Spock");
        }
    }
}
