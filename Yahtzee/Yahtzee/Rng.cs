using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Rng
    {
        private static Random rnd = new Random();
        
        public int DiceRng()
        {
            int x = rnd.Next(1, 7);
            return x;
        }
    }
}
