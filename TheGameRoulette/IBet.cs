using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.Legacy;

namespace TheGameRoulette
{
    public interface IBet
    {
        uint WonAmount(Field field);
        string PlayerName { get; }
         uint Amount { get; }

    }
}
