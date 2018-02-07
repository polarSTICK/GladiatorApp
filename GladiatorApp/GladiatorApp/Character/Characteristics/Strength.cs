using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Strength
    {
        private double _attackPhys;
        private int _strength;

        public Strength(int strength)
        {
            _attackPhys = strength * 3;
            _strength = strength;
        }
    }
}
