using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Agility
    {
        private int _agility;
        private double _turnSpeed;
        private double _dodgeChance;

        public Agility(int agility)
        {
            _agility = agility;
            _turnSpeed = agility * 10;
            _dodgeChance = agility * 1.5;
        }
    }
}
