using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Willpower
    {
        private int _willpower;
        private double _attackMagic;
        private double _mana;

        public Willpower(int willpower)
        {
            _willpower = willpower;
            _attackMagic = willpower * 3;
            _mana = willpower * 10;
        }
    }
}
