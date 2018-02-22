using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRoulette
{
    class FakeRoulette
    {
        public const uint Red = 0;
        public const uint Black = 1;
        public const uint Green = 2;

        private uint _color;
        private uint _number;
        public FakeRoulette(uint color, uint number)
        {
            _color = color;
            _number = number;
        }

        public uint Number()
        {
            return 0;
        }

        public uint Color()
        {
            return 0;
        }
    }
}
