using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Constitution
    {
        private int _contitution;
        private double _health;
        private double _resPhys;

        public Constitution(int constitution)
        {
            _contitution = constitution;
            _health = constitution * 10;
            _resPhys = constitution * 1.5;
        }
    }
}
