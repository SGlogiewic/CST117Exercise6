using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117Exercise6
{
    class Dice
    {
        private int numbOfSides;
        static Random randy = new Random();
        public Dice(int i) 
        {
            numbOfSides = i;
        }
        public int rollDie() 
        {
            int val = 0;
            int randyNumb = randy.Next();
            val = randyNumb % numbOfSides + 1;
            return val;
        }
    }
}
