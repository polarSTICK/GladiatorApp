using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Dexterity
    {
        private int _dexterity;
        private double _hitChance;
        private double _critChance;
        
        public Dexterity(int dexterity)
        {
            _dexterity = dexterity;
            _hitChance = dexterity * 10;
            _critChance = dexterity * 1.5;
        }
    }
}
