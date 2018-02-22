using System;
using System.Collections.Generic;
using TheGameRoulette;

namespace RouletteGame.Legacy
{
    public class Roulette
    {
        private readonly List<Field> _fields;
        private Field _result;
        private IRandom _randomizer;
        private IFieldFactory _factory;

        public Roulette(IRandom randomizer,IFieldFactory factory)
        {
            _randomizer = randomizer;
            _factory = factory;
            _fields = _factory.CreateFields();
            _result = _fields[0];
        }

        public void Spin()
        {
            var n = _randomizer.Next();
            _result = _fields[(int) n];
        }

        public Field GetResult()
        {
            return _result;
        }
    }
}