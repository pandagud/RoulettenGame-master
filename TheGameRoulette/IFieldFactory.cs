using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.Legacy;

namespace TheGameRoulette
{
    public interface IFieldFactory
    {
        List<Field> CreateFields();
    }
}
