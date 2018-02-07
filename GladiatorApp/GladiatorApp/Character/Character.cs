using System;
using System.Collections.Generic;
using System.Text;

namespace GladiatorApp.Character
{
    public class Character
    {
        private Strength _strength;
        private Constitution _constitution;
        private Dexterity _dexterity;
        private Agility _agility;
        private Intellect _intellect;
        private Willpower _willpower;

        public Character(int strength, int constitution, int dexterity, int agility, int intellect, int willpower)
        {
            _strength = new Strength(strength);
            _constitution = new Constitution(constitution);
            _dexterity = new Dexterity(dexterity);
            _agility = new Agility(agility);
            _intellect = new Intellect(intellect);
            _willpower = new Willpower(willpower);
        }
        
        //public int Strength { get => _strength; set => _strength = value; }
        //public int Constitution { get => _constitution; set => _constitution = value; }
        //public int Dexterity { get => _dexterity; set => _dexterity = value; }
        //public int Agility { get => _agility; set => _agility = value; }
        //public int Intellect { get => _intellect; set => _intellect = value; }
        //public int Willpower { get => _willpower; set => _willpower = value; }
    }
}
