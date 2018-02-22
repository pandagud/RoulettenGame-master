using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRoulette
{
    class Randomizer : IRandom 
    {

        public uint Next()
        {
            var nextRandom = (uint) new Random().Next(0, 37);
            return nextRandom;
        }

    }
}
