using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public struct Intellect
    {
        private int _intellect;
        private double _resMental;

        public Intellect(int intellect)
        {
            _intellect = intellect;
            _resMental = intellect * 1.5;
        }
    }
}
